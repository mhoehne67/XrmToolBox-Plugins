using mho.PluginStepsViewer.EarlyBoundTypes;
using Microsoft.Xrm.Sdk;
using System;
using System.Windows.Forms;

namespace mho.PluginStepsViewer.Display
{
	/// <summary>
	/// Serves as a summary for SdkMessageProcessingStep. It's the source for the
	/// DataGridView.
	/// </summary>
	public class PluginStepSummary
	{
		private SdkMessageProcessingStep step;
		private bool isFullyLoaded = false;

		public string Name { get; private set; }
		public string Type { get; private set; }
		public string Assembly { get; private set; }
		public string Mode => $"{step.Mode}";
		public string Stage => $"{step.Stage}";
		public string Message => $"{step.SdkMessageId?.Name}";
		public int Rank => step.Rank ?? 0;
		public string PrimaryEntity => $"{step.PrimaryObjectTypeCode}";
		public string SecondaryEntity => $"{step.SecondaryObjectTypeCode}";

		internal PluginStepSummary(PluginAssembly assembly, PluginType type, SdkMessageProcessingStep step)
		{
			this.step = step;

			Name = step.Name;
			Type = type.Name;
			Assembly = assembly.Name;
		}

		internal Guid? GetSdkMessageFilterId()
		{
			return step.SdkMessageFilterId == null ? (Guid?)null : step.SdkMessageFilterId.Id;
		}

		public void DisplayInPropertyGrid(PropertyGrid propertyGrid, IOrganizationService service)
		{
			if (!isFullyLoaded)
			{
				isFullyLoaded = true;

				var fullStep = new SdkMessageProcessingStep(service.Retrieve(
					SdkMessageProcessingStep.EntityLogicalName,
					step.SdkMessageProcessingStepId.Value,
					new Microsoft.Xrm.Sdk.Query.ColumnSet(true)));

				step.UpdateAttributes(fullStep.Attributes);
			}

			propertyGrid.SelectedObject = new SdkMessageProcessingStepDisplay(step);
		}
	}
}
