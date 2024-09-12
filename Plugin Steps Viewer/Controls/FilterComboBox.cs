using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace mho.PluginStepsViewer
{
	/// <summary>
	/// A combo box with three options: "contains", "begins with" and "is".
	/// </summary>
	public class FilterComboBox : ComboBox
	{
		public FilterComboBox() : base()
		{
		}

		/// <summary>
		/// Gets or sets the FilterOperator.
		/// </summary>
		public FilterOperator FilterOperator
		{
			get => SelectedIndex <= 0 ? FilterOperator.Contains : (FilterOperator)SelectedIndex;
			set
			{
				var index = (int)value;

				if (index < Items.Count)
					SelectedIndex = index;
			}
		}

		/// <summary>
		/// Dynamically add the options if not already added.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnDropDown(EventArgs e)
		{
			base.OnDropDown(e);

			if (Items.Count != 3)
			{
				Items.Clear();
				Items.AddRange(new object[] {
					"contains",
					"begins with",
					"is"});
			}
		}



		private FilterSettings _filterSettings;

		public void SetFilterSettings(FilterSettings filter)
		{
			_filterSettings = filter;

			FilterOperator = filter.Operator;

			if (FilteringComboBox != null)
				FilteringComboBox.Text = filter.Value;
			else if (FilteringTextBox != null)
				FilteringTextBox.Text = filter.Value;
		}


		public void SaveSettings()
		{
			if (_filterSettings != null)
			{
				_filterSettings.Operator = FilterOperator;
				_filterSettings.Value = GetFilterText();
			}
		}


		private ComboBox _filteringComboBox;

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Bindable(true)]
		public ComboBox FilteringComboBox
		{
			get => _filteringComboBox;
			set
			{
				_filteringComboBox = value;

				if (_filteringComboBox != null)
				{
					_filteringComboBox.SelectedIndexChanged += (sender, e) =>
					{
						if (_filteringComboBox.SelectedIndex >= 0)
							FilterOperator = FilterOperator.Is;
					};

					_filteringComboBox.TextChanged += (sender, e) =>
					{
						if (_filteringComboBox.Text == "")
							FilterOperator = FilterOperator.Contains;
					};
				}
			}
		}

		private TextBox _filteringTextBox;

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Bindable(true)]
		public TextBox FilteringTextBox
		{
			get => _filteringTextBox;
			set
			{
				_filteringTextBox = value;

				if (_filteringTextBox != null)
				{
					_filteringTextBox.TextChanged += (sender, e) =>
					{
						if (_filteringTextBox.Text == "")
							FilterOperator = FilterOperator.Contains;
					};
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Bindable(true)]
		public string FilteredPropertyName { get; set; }

		public string GetFilterText()
		{
			if (FilteringComboBox != null)
				return FilteringComboBox.Text;

			if (FilteringTextBox != null)
				return FilteringTextBox.Text;

			return "";
		}

		public void SetPredefinedFilters(List<string> items)
		{
			if (FilteringComboBox != null)
			{
				FilteringComboBox.Items.Clear();
				FilteringComboBox.Items.AddRange(items.ToArray());
			}
		}

		/// <summary>
		/// Filters a list of items using the current filter operator and
		/// the given property and comparison value. The property must be
		/// a public member of T.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="items"></param>
		/// <param name="property"></param>
		/// <param name="compareTo"></param>
		/// <returns></returns>
		public List<T> Filter<T>(List<T> items)
		{
			string compareTo = GetFilterText();
			PropertyInfo propertyInfo = typeof(T).GetProperty(FilteredPropertyName);

			if (propertyInfo == null)
				return items;

			if (compareTo == null)
				compareTo = "";

			bool isEmptyComparator = compareTo.Length == 0;

			if (FilterOperator != FilterOperator.Is && isEmptyComparator)
				return items;

			compareTo = compareTo.ToLower();
			var result = new List<T>();

			foreach (T item in items)
			{
				string itemPropertyValue = (string)propertyInfo.GetValue(item);

				if (itemPropertyValue == null)
					itemPropertyValue = "";

				itemPropertyValue = itemPropertyValue.ToLower();

				switch (FilterOperator)
				{
					case FilterOperator.Contains:
						if (isEmptyComparator || itemPropertyValue.Contains(compareTo))
							result.Add(item);
						break;

					case FilterOperator.BeginsWith:
						if (isEmptyComparator || itemPropertyValue.StartsWith(compareTo))
							result.Add(item);
						break;

					case FilterOperator.Is:
						if (itemPropertyValue == compareTo)
							result.Add(item);
						break;
				}
			}

			return result;
		}
	}

	/// <summary>
	/// The supported filters.
	/// </summary>
	public enum FilterOperator
	{
		Contains = 0,
		BeginsWith = 1,
		Is = 2
	}
}
