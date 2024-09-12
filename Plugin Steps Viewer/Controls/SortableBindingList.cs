using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace mho.PluginStepsViewer
{
	public class SortableBindingList<T> : BindingList<T>
	{
		/// <summary>
		/// Reference to the list provided at the time of instantiation 
		/// </summary>
		private List<T> _originalList;

		/// <summary>
		/// Sort direction
		/// </summary>
		private ListSortDirection _sortDirection;

		/// <summary>
		/// Name of the property serving as the sort column.
		/// </summary>
		private PropertyDescriptor _sortProperty;

		/// <summary>
		/// Function that refreshes the contents of the base collection of elements
		/// </summary>
		private Action<SortableBindingList<T>, List<T>> _populateBaseList = (a, b) => a.ResetItems(b);

		/// <summary>
		/// A cache of functions that perform the sorting for a given type, property, and sort direction
		/// </summary>
		private static readonly Dictionary<string, Func<List<T>, IEnumerable<T>>>
			_cachedOrderByExpressions = new Dictionary<string, Func<List<T>, IEnumerable<T>>>();

		public SortableBindingList()
		{
			_originalList = new List<T>();
		}

		public SortableBindingList(IEnumerable<T> enumerable)
		{
			_originalList = enumerable.ToList();
			_populateBaseList(this, _originalList);
		}

		public SortableBindingList(List<T> list)
		{
			_originalList = list;
			_populateBaseList(this, _originalList);
		}

		protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
			/*
			 Look for an appropriate sort method in the cache if not found.
			 Call CreateOrderByMethod to create one. 
			 Apply it to the original list.
			 Notify any bound controls that the sort has been applied.
			 */

			_sortProperty = prop;

			var orderByMethodName = (_sortDirection == ListSortDirection.Ascending) ? "OrderBy" : "OrderByDescending";
			var cacheKey = typeof(T).GUID + prop.Name + orderByMethodName;

			if (!_cachedOrderByExpressions.ContainsKey(cacheKey))
				CreateOrderByMethod(prop, orderByMethodName, cacheKey);

			ResetItems(_cachedOrderByExpressions[cacheKey](_originalList).ToList());
			ResetBindings();

			_sortDirection = SwapSortDirection(_sortDirection);
		}

		private ListSortDirection SwapSortDirection(ListSortDirection direction)
		{
			return (direction == ListSortDirection.Ascending) ?
				ListSortDirection.Descending : ListSortDirection.Ascending;
		}


		private void CreateOrderByMethod(PropertyDescriptor prop, string orderByMethodName, string cacheKey)
		{
			/*
			 Create a generic method implementation for IEnumerable<T>.
			 Cache it.
			*/

			var sourceParameter = Expression.Parameter(typeof(List<T>), "source");
			var lambdaParameter = Expression.Parameter(typeof(T), "lambdaParameter");
			var accessedMember = typeof(T).GetProperty(prop.Name);

			if (accessedMember != null)
			{
				var propertySelectorLambda =
					 Expression.Lambda(Expression.MakeMemberAccess(lambdaParameter, accessedMember), lambdaParameter);

				var orderByMethod = typeof(Enumerable).GetMethods()
					.Where(a => a.Name == orderByMethodName && a.GetParameters().Length == 2)
					.Single()
					.MakeGenericMethod(typeof(T), prop.PropertyType);

				var orderByExpression = Expression.Lambda<Func<List<T>, IEnumerable<T>>>(
					Expression.Call(orderByMethod, new Expression[] { sourceParameter, propertySelectorLambda }),
					sourceParameter);

				_cachedOrderByExpressions.Add(cacheKey, orderByExpression.Compile());
			}
		}

		protected override void RemoveSortCore()
		{
			ResetItems(_originalList);
		}

		private void ResetItems(List<T> items)
		{
			base.ClearItems();
			int i = 0;

			foreach (var item in items)
			{
				base.InsertItem(i, item);
				i++;
			}
		}

		protected override bool SupportsSortingCore => true;
		protected override ListSortDirection SortDirectionCore => _sortDirection;
		protected override PropertyDescriptor SortPropertyCore => _sortProperty;

		protected override void OnListChanged(ListChangedEventArgs e)
		{
			_originalList = base.Items.ToList();
		}
	}
}
