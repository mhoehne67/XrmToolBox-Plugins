using mho.PluginStepsViewer.EarlyBoundTypes;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using mho.PluginStepsViewer.Display;
using System;


namespace mho.PluginStepsViewer
{
	/// <summary>
	/// Loads requested assemblies, types and steps.
	/// </summary>
	internal class PluginStepsLoader
	{
		public List<PluginAssembly> Assemblies { get; private set; }
		public List<PluginType> Types { get; private set; }
		public List<SdkMessageProcessingStep> Steps { get; private set; }
		public List<PluginStepSummary> StepSummaries { get; private set; }
		public SortableBindingList<PluginStepSummary> SortableBindingList { get; private set; }

		public List<string> AssemblyNames { get; private set; }
		public List<string> TypeNames { get; private set; }
		public List<string> Modes { get; private set; }
		public List<string> Stages { get; private set; }
		public List<string> Messages { get; private set; }
		public List<string> PrimaryEntityNames { get; private set; }
		public List<string> SecondaryEntityNames { get; private set; }

		readonly IOrganizationService Service;
		readonly BackgroundWorker BackgroundWorker;

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="service">The organization service passed from the XrmToolBox.</param>
		/// <param name="backgroundWorker">The background worker instance launched from the plugin control.</param>
		public PluginStepsLoader(IOrganizationService service, BackgroundWorker backgroundWorker)
		{
			Service = service;
			BackgroundWorker = backgroundWorker;
		}

		/// <summary>
		/// Loads the entire information to be displayed in the data grid view of
		/// the plugin steps viewer control.
		/// </summary>
		/// <param name="excludedAssemblyNamePrefixes"></param>
		public void LoadAsync(List<string> excludedAssemblyNamePrefixes)
		{
			BackgroundWorker.ReportProgress(0, "Loading assemblies...");
			LoadAssemblies(excludedAssemblyNamePrefixes);

			BackgroundWorker.ReportProgress(10, "Loading types...");
			LoadTypes();

			BackgroundWorker.ReportProgress(30, "Loading steps...");
			LoadSteps();

			BackgroundWorker.ReportProgress(80, "Building summary...");
			BuildSummary();

			BackgroundWorker.ReportProgress(90, "Sending data to UI...");
			SortableBindingList = new SortableBindingList<PluginStepSummary>(StepSummaries);
		}


		/// <summary>
		/// Loads the plugin assembly names that are not excluded.
		/// </summary>
		/// <param name="excludedAssemblyNamePrefixes">
		/// A list of assembly name prefixes. Any assembly having a name starting
		/// with one of these names will be ignored.
		/// </param>
		private void LoadAssemblies(List<string> excludedAssemblyNamePrefixes)
		{
			var query = new QueryExpression(PluginAssembly.EntityLogicalName)
			{
				ColumnSet = new ColumnSet(PluginAssembly.Fields.Name)
			};

			foreach (string excludedAssembly in excludedAssemblyNamePrefixes)
				query.Criteria.AddCondition(PluginAssembly.Fields.Name, ConditionOperator.DoesNotBeginWith, excludedAssembly);

			query.AddOrder(PluginAssembly.Fields.Name, OrderType.Ascending);

			EntityCollection entities = Service.RetrieveMultiple(query);
			Assemblies = new List<PluginAssembly>();

			foreach (Entity assembly in entities.Entities)
				Assemblies.Add(new PluginAssembly(assembly));
		}


		/// <summary>
		/// Loads the plugin types of the assemblies stored in <see cref="Assemblies"/>. 
		/// You must call LoadAssemblies first.
		/// </summary>
		private void LoadTypes()
		{
			List<object> ids = Assemblies.Select(a => (object)a.PluginAssemblyId).Distinct().ToList();

			var query = new QueryExpression(PluginType.EntityLogicalName)
			{
				ColumnSet = new ColumnSet(true)
			};

			query.Criteria.AddCondition(PluginType.Fields.PluginAssemblyId, ConditionOperator.In, ids.ToArray());
			query.AddOrder(PluginType.Fields.Name, OrderType.Ascending);

			EntityCollection entities = Service.RetrieveMultiple(query);
			Types = new List<PluginType>();

			foreach (Entity type in entities.Entities)
				Types.Add(new PluginType(type));
		}

		/// <summary>
		/// Loads the plugin steps of the types stored in <see cref="Types"/>.
		/// You must call LoadTypes first.
		/// </summary>
		private void LoadSteps()
		{
			object[] ids = Types.Select(t => (object)t.PluginTypeId).Distinct().ToArray();

			var query = new QueryExpression(SdkMessageProcessingStep.EntityLogicalName)
			{
				// ColumnSet = new ColumnSet(true)
				ColumnSet = new ColumnSet(
					SdkMessageProcessingStep.Fields.Name,
					SdkMessageProcessingStep.Fields.Mode,
					SdkMessageProcessingStep.Fields.Stage,
					SdkMessageProcessingStep.Fields.SdkMessageId,
					SdkMessageProcessingStep.Fields.SdkMessageFilterId,
					SdkMessageProcessingStep.Fields.Rank,
					SdkMessageProcessingStep.Fields.PluginTypeId
					)
			};

			query.Criteria.AddCondition(SdkMessageProcessingStep.Fields.PluginTypeId, ConditionOperator.In, ids);
			query.AddOrder(SdkMessageProcessingStep.Fields.Name, OrderType.Ascending);

			var filter = query.AddLink(
				SdkMessageFilter.EntityLogicalName, 
				SdkMessageProcessingStep.Fields.SdkMessageFilterId, 
				SdkMessageFilter.Fields.SdkMessageFilterId);

			filter.EntityAlias = SdkMessageProcessingStep.SdkMessageFilterAlias;
			
			filter.Columns.AddColumns(
				SdkMessageFilter.Fields.PrimaryObjectTypeCode, 
				SdkMessageFilter.Fields.SecondaryObjectTypeCode);

			int numRecordsRetrieved = 0;

			query.PageInfo.Count = 5000;
			query.PageInfo.PageNumber = 1;

			Steps = new List<SdkMessageProcessingStep>();

			while (true)
			{
				EntityCollection entities = Service.RetrieveMultiple(query);

				if (entities.Entities.Count == 0)
					return;

				numRecordsRetrieved += entities.Entities.Count;
				BackgroundWorker.ReportProgress(50, $"Loading steps... {numRecordsRetrieved}");

				foreach (Entity step in entities.Entities)
					Steps.Add(new SdkMessageProcessingStep(step));

				if (!entities.MoreRecords)
					break;

				query.PageInfo.PagingCookie = entities.PagingCookie;
				query.PageInfo.PageNumber++;
			}
		}

		/// <summary>
		/// Builds the summary of the retrieved steps. 
		/// </summary>
		private void BuildSummary()
		{
			StepSummaries = new List<PluginStepSummary>();

			foreach (SdkMessageProcessingStep step in Steps)
			{
				PluginType type = Types.FirstOrDefault(t => t.PluginTypeId == step.PluginTypeId.Id);
				PluginAssembly assembly = Assemblies.FirstOrDefault(a => a.PluginAssemblyId == type.PluginAssemblyId.Id);
				var stepSummary = new PluginStepSummary(assembly, type, step);
				StepSummaries.Add(stepSummary);
			}

			Modes = StepSummaries.Select(a => a.Mode ?? "").Distinct().ToList();
			Modes.Sort();

			Stages = StepSummaries.Select(a => a.Stage ?? "").Distinct().ToList();
			Stages.Sort();

			Messages = StepSummaries.Select(a => a.Message ?? "").Distinct().ToList();
			Messages.Sort();

			PrimaryEntityNames = StepSummaries.Select(a => a.PrimaryEntity ?? "").Distinct().ToList();
			PrimaryEntityNames.Sort();

			SecondaryEntityNames = StepSummaries.Select(a => a.SecondaryEntity ?? "").Distinct().ToList();
			SecondaryEntityNames.Sort();

			AssemblyNames = Assemblies.Select(a => a.Name ?? "").ToList();
			AssemblyNames.Sort();
						
			TypeNames = Types.Select(a => a.Name ?? "").ToList();
			TypeNames.Sort();
		}
	}
}
