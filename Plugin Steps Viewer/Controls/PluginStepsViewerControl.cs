using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using mho.PluginStepsViewer.Display;
using XrmToolBox.Extensibility.Interfaces;
using XrmToolBox.Extensibility.Args;

namespace mho.PluginStepsViewer
{
	public partial class PluginStepsViewerControl : PluginControlBase, IStatusBarMessenger
	{

		/// <summary>
		/// XrmToolBox interface IStatusBarMessenger
		/// </summary>
		public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;

		/// <summary>
		/// The list of all retrieved plugin steps.
		/// </summary>
		List<PluginStepSummary> _allSteps = new List<PluginStepSummary>();

		/// <summary>
		/// Set to true during initilization of a new connection to prevent useless filterings.
		/// <seealso cref="FilterSteps"/>
		/// </summary>
		bool _isFilteringSuppressed = false;

		/// <summary>
		/// Settings for the current connection.
		/// </summary>
		private ConnectionSettings _connectionSettings;

		/// <summary>
		/// Holds a list of all comboboxes that filter the retrieved steps.
		/// </summary>
		private readonly List<FilterComboBox> _filterComboBoxes;


		/// <summary>
		/// Initializes a new instance of the user control that is displayed
		/// in the Xrm Toolbox.
		/// </summary>
		public PluginStepsViewerControl()
		{
			InitializeComponent();
			ResetExcludedAssembliesToLastSavedState();

			_filterComboBoxes = new List<FilterComboBox>
			{
				comboFilterAssemblyOperator,
				comboFilterTypeOperator,
				comboFilterNameOperator,
				comboFilterModeOperator,
				comboFilterStageOperator,
				comboFilterMessageOperator,
				comboFilterPrimaryEntityOperator,
				comboFilterSecondaryEntityOperator
			};
		}

		/// <summary>
		/// Resets the list of excluded assemblies to the last saved state.
		/// </summary>
		private void ResetExcludedAssembliesToLastSavedState()
		{
			SetExcludedAssemblies(GlobalSettings.Read().ExcludedAssemblies);
		}

		/// <summary>
		/// Populates the UI with the list of excluded assembly names.
		/// </summary>
		/// <param name="excludedAssemblies"></param>
		private void SetExcludedAssemblies(List<string> excludedAssemblies)
		{
			textBoxExcludedAssemblies.Text = string.Join("\r\n", excludedAssemblies);
		}

		/// <summary>
		/// Save the current filters so that they can serve as a default when using
		/// the same connection next time.
		/// </summary>
		private void SaveFilters()
		{
			if (_connectionSettings != null)
			{
				// we were already connected to an organization, so lets save the filter settings
				foreach (var combo in _filterComboBoxes)
					combo.SaveSettings();

				ConnectionSettings.Save(_connectionSettings);
			}
		}

		/// <summary>
		/// Reads and applies the settings for the current connection.
		/// </summary>
		/// <param name="connectionId">The connection id as provided by Xrm Toolbox.</param>
		private void ApplyConnectionSettings(Guid? connectionId)
		{
			_connectionSettings = ConnectionSettings.Read(connectionId);

			comboFilterAssemblyOperator.SetFilterSettings(_connectionSettings.Assembly);			
			comboFilterTypeOperator.SetFilterSettings(_connectionSettings.Type);
			comboFilterNameOperator.SetFilterSettings(_connectionSettings.Name);
			comboFilterModeOperator.SetFilterSettings(_connectionSettings.Mode);
			comboFilterStageOperator.SetFilterSettings(_connectionSettings.Stage);
			comboFilterMessageOperator.SetFilterSettings(_connectionSettings.Message);
			comboFilterPrimaryEntityOperator.SetFilterSettings(_connectionSettings.PrimaryEntity);
			comboFilterSecondaryEntityOperator.SetFilterSettings(_connectionSettings.SecondaryEntity);
		}


		/// <summary>
		/// A user can decide to change the connection of an already open plugin. In this case, Service property 
		/// is automatically updated. But sometimes, you may want get more information about this change or perform 
		/// some action after this change (like reloading some data for the newly connected organization). 
		/// You can override the method UpdateConnection to get more information or perform some action.
		/// </summary>
		/// <param name="newService"></param>
		/// <param name="detail"></param>
		/// <param name="actionName"></param>
		/// <param name="parameter"></param>
		public override void UpdateConnection(
			Microsoft.Xrm.Sdk.IOrganizationService newService, 
			global::McTools.Xrm.Connection.ConnectionDetail detail, 
			string actionName, 
			object parameter)
		{
			_isFilteringSuppressed = true;

			SaveFilters();
			base.UpdateConnection(newService, detail, actionName, parameter);
			ApplyConnectionSettings(detail.ConnectionId);

			_isFilteringSuppressed = false;

			ReloadSteps();
		}


		/// <summary>
		/// Asynchronously reloads the steps from the connected environment. Excludes
		/// any assembly being listed in the assembly exclusion list.
		/// </summary>
		private void ReloadSteps()
		{

			WorkAsync(new WorkAsyncInfo
			{
				Message = "Retrieving registered steps...",

				Work = (w, e) =>
				{
					// This code is executed in another thread
					var loader = new PluginStepsLoader(Service, w);
					loader.LoadAsync(GetExcludedAssemblies());
					e.Result = loader;
				},

				ProgressChanged = e =>
				{
					// it will display "I have found the user id" in this example					
					SetWorkingMessage(e.UserState.ToString());
					SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(e.ProgressPercentage, "Loading..."));
				},

				PostWorkCallBack = e =>
				{
					// This code is executed in the main thread
					SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(0, ""));
					PluginStepsLoader loader = (PluginStepsLoader)e.Result;

					statusLabelNumAssemblies.Text = $"Assemblies: {loader.Assemblies.Count}";
					statusLabelNumTypes.Text = $"Types: {loader.Types.Count}";
					statusLabelNumSteps.Text = $"Steps: {loader.Steps.Count}";
					statusLabelNumDisplayedSteps.Text = $"Displayed Steps: {loader.Steps.Count}";

					_allSteps = loader.StepSummaries;

					comboFilterAssemblyOperator.SetPredefinedFilters(loader.AssemblyNames);
					comboFilterTypeOperator.SetPredefinedFilters(loader.TypeNames);
					comboFilterModeOperator.SetPredefinedFilters(loader.Modes);
					comboFilterStageOperator.SetPredefinedFilters(loader.Stages);
					comboFilterMessageOperator.SetPredefinedFilters(loader.Messages);
					comboFilterPrimaryEntityOperator.SetPredefinedFilters(loader.PrimaryEntityNames);
					comboFilterSecondaryEntityOperator.SetPredefinedFilters(loader.SecondaryEntityNames);
					
					dataGridViewPluginStepsDisplay.DataSource = loader.SortableBindingList;

					foreach (DataGridViewColumn column in dataGridViewPluginStepsDisplay.Columns)
						column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

					dataGridViewPluginStepsDisplay.AutoResizeColumns();
					propertyGridPluginStep.SelectedObject = null;

					FilterSteps();
				},

				AsyncArgument = null,
				// Progress information panel size
				MessageWidth = 340,
				MessageHeight = 150
			});
		}


		void FilterSteps()
		{
			if (_isFilteringSuppressed)
				return;

			var filteredSteps = new List<PluginStepSummary>(_allSteps);

			foreach(var combo in _filterComboBoxes)
				filteredSteps = combo.Filter(filteredSteps);

			dataGridViewPluginStepsDisplay.DataSource = new SortableBindingList<PluginStepSummary>(filteredSteps);
			statusLabelNumDisplayedSteps.Text = "Displayed Steps: " + filteredSteps.Count;

			SaveFilters();
		}

		private void dataGridViewPluginStepsDisplay_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewPluginStepsDisplay.CurrentRow.DataBoundItem is PluginStepSummary step)
				step.DisplayInPropertyGrid(propertyGridPluginStep, Service);
		}

		private void FilterChanged(object sender, EventArgs e)
		{
			FilterSteps();
		}

		private void toolStripButtonExecute_Click(object sender, EventArgs e)
		{
			ReloadSteps();
		}

		private List<string> GetExcludedAssemblies()
		{
			string[] excludedAssemblies = textBoxExcludedAssemblies.Text.Replace("\r", "").Split('\n');
			var excludedAssembliesList = new List<string>();
			var excludedAssembliesListToLower = new List<string>();

			foreach (string name in excludedAssemblies)
			{
				string trimmedName = name.Trim();

				if (trimmedName.Length > 0 && !excludedAssembliesListToLower.Contains(trimmedName))
				{
					excludedAssembliesList.Add(trimmedName);
					excludedAssembliesListToLower.Add(trimmedName.ToLower());
				}
			}

			return excludedAssembliesList;
		}

		private void toolStripButtonSaveSettings_Click(object sender, EventArgs e)
		{
			var excludedAssembliesList = GetExcludedAssemblies();
			SetExcludedAssemblies(excludedAssembliesList);

			var settings = GlobalSettings.Read();
			settings.ExcludedAssemblies = excludedAssembliesList;
			GlobalSettings.Save(settings);
		}

		private void toolStripButtonResetToLastSavedState_Click(object sender, EventArgs e)
		{
			ResetExcludedAssembliesToLastSavedState();
		}

		private void toolStripButtonDiscardSettings_Click(object sender, EventArgs e)
		{
			SetExcludedAssemblies(GlobalSettings.DefaultExcludedAssemblies);
		}
	}
}
