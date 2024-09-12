using mho.PluginStepsViewer.EarlyBoundTypes;
using Microsoft.Xrm.Sdk;

namespace mho.PluginStepsViewer.Display
{
	/// <summary>
	/// A wrapper for SdkMessageProcessingStep that can be viewed in a property grid.	
	/// </summary>
	public class SdkMessageProcessingStepDisplay
	{
		readonly SdkMessageProcessingStep step;
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageProcessingStepDisplay(SdkMessageProcessingStep step)
		{
			this.step = step;
		}

		/// <summary>
		/// Indicates whether the asynchronous system job is automatically deleted on completion.
		/// </summary>
		public System.Nullable<bool> AsyncAutoDelete => step.AsyncAutoDelete;

		public System.Nullable<bool> CanBeBypassed => step.CanBeBypassed;

		/// <summary>
		/// Identifies whether a SDK Message Processing Step type will be ReadOnly or Read Write. false - ReadWrite, true - ReadOnly 
		/// </summary>
		public System.Nullable<bool> CanUseReadOnlyConnection => step.CanUseReadOnlyConnection;

		/// <summary>
		/// For internal use only.
		/// </summary>
		public string Category => step.Category;

		/// <summary>
		/// For internal use only.
		/// </summary>
		public componentstate? ComponentState => step.ComponentState;

		/// <summary>
		/// Step-specific configuration for the plug-in type. Passed to the plug-in constructor at run time.
		/// </summary>
		public string Configuration => step.Configuration;

		/// <summary>
		/// Unique identifier of the user who created the SDK message processing step.
		/// </summary>		
		public EntityReferenceDisplay CreatedBy => new EntityReferenceDisplay(step.CreatedBy);

		/// <summary>
		/// Date and time when the SDK message processing step was created.
		/// </summary>
		public System.Nullable<System.DateTime> CreatedOn => step.CreatedOn;

		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageprocessingstep.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy => step.CreatedOnBehalfBy;
		public EntityReferenceDisplay CreatedOnBehalfBy => new EntityReferenceDisplay(step.CreatedOnBehalfBy);

		/// <summary>
		/// Customization level of the SDK message processing step.
		/// </summary>
		public System.Nullable<int> CustomizationLevel => step.CustomizationLevel;

		/// <summary>
		/// Description of the SDK message processing step.
		/// </summary>
		public string Description => step.Description;

		/// <summary>
		/// EnablePluginProfiler
		/// </summary>
		public System.Nullable<bool> EnablePluginProfiler => step.EnablePluginProfiler;

		/// <summary>
		/// Configuration for sending pipeline events to the Event Expander service.
		/// </summary>
		public string EventExpander => step.EventExpander;

		/// <summary>
		/// Unique identifier of the associated event handler.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference EventHandler => step.EventHandler;
		public EntityReferenceDisplay EventHandler => new EntityReferenceDisplay(step.EventHandler);

		/// <summary>
		/// Comma-separated list of attributes. If at least one of these attributes is modified, the plug-in should execute.
		/// </summary>
		public string FilteringAttributes => step.FilteringAttributes;

		/// <summary>
		/// Unique identifier for fxexpression associated with SdkMessageProcessingStep.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference FxExpressionId => step.FxExpressionId;
		public EntityReferenceDisplay FxExpressionId => new EntityReferenceDisplay(step.FxExpressionId);

		/// <summary>
		/// Unique identifier of the user to impersonate context when step is executed.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference ImpersonatingUserId => step.ImpersonatingUserId;
		public EntityReferenceDisplay ImpersonatingUserId => new EntityReferenceDisplay(step.ImpersonatingUserId);

		/// <summary>
		/// Version in which the form is introduced.
		/// </summary>
		public string IntroducedVersion => step.IntroducedVersion;

		/// <summary>
		/// Identifies if a plug-in should be executed from a parent pipeline, a child pipeline, or both.
		/// </summary>
		public sdkmessageprocessingstep_invocationsource? InvocationSource => step.InvocationSource;

		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		public bool? IsCustomizable => step.IsCustomizable == null ? null : (bool?)step.IsCustomizable.Value;

		/// <summary>
		/// Information that specifies whether this component should be hidden.
		/// </summary>
		public bool? IsHidden => step.IsHidden == null ? null : (bool?)step.IsHidden.Value;

		/// <summary>
		/// Information that specifies whether this component is managed.
		/// </summary>
		public System.Nullable<bool> IsManaged => step.IsManaged;

		/// <summary>
		/// Run-time mode of execution, for example, synchronous or asynchronous.
		/// </summary>
		public sdkmessageprocessingstep_mode? Mode => step.Mode;

		/// <summary>
		/// Unique identifier of the user who last modified the SDK message processing step.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference ModifiedBy => step.ModifiedBy;
		public EntityReferenceDisplay ModifiedBy => new EntityReferenceDisplay(step.ModifiedBy);

		/// <summary>
		/// Date and time when the SDK message processing step was last modified.
		/// </summary>
		public System.Nullable<System.DateTime> ModifiedOn => step.ModifiedOn;

		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageprocessingstep.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy => step.ModifiedOnBehalfBy;
		public EntityReferenceDisplay ModifiedOnBehalfBy => new EntityReferenceDisplay(step.ModifiedOnBehalfBy);

		/// <summary>
		/// Name of SdkMessage processing step.
		/// </summary>
		public string Name => step.Name;

		/// <summary>
		/// Unique identifier of the organization with which the SDK message processing step is associated.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference OrganizationId => step.OrganizationId;
		public EntityReferenceDisplay OrganizationId => new EntityReferenceDisplay(step.OrganizationId);

		/// <summary>
		/// For internal use only.
		/// </summary>
		public System.Nullable<System.DateTime> OverwriteTime => step.OverwriteTime;

		/// <summary>
		/// Unique identifier of the plug-in type associated with the step.
		/// </summary>
		[System.ObsoleteAttribute()]
		//public Microsoft.Xrm.Sdk.EntityReference PluginTypeId => step.PluginTypeId;
		public EntityReferenceDisplay PluginTypeId => new EntityReferenceDisplay(step.PluginTypeId);

		/// <summary>
		/// Unique identifier for powerfxrule associated with SdkMessageProcessingStep.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference PowerfxRuleId => step.PowerfxRuleId;
		public EntityReferenceDisplay PowerfxRuleId => new EntityReferenceDisplay(step.PowerfxRuleId);

		/// <summary>
		/// Processing order within the stage.
		/// </summary>
		public System.Nullable<int> Rank => step.Rank;

		/// <summary>
		/// For internal use only. Holds miscellaneous properties related to runtime integration.
		/// </summary>
		public string RuntimeIntegrationProperties => step.RuntimeIntegrationProperties;

		/// <summary>
		/// Unique identifier of the SDK message filter.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference SdkMessageFilterId => step.SdkMessageFilterId;
		public EntityReferenceDisplay SdkMessageFilterId => new EntityReferenceDisplay(step.SdkMessageFilterId);

		/// <summary>
		/// Unique identifier of the SDK message.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference SdkMessageId => step.SdkMessageId;
		public EntityReferenceDisplay SdkMessageId => new EntityReferenceDisplay(step.SdkMessageId);

		/// <summary>
		/// Unique identifier of the SDK message processing step entity.
		/// </summary>
		public System.Nullable<System.Guid> SdkMessageProcessingStepId => step.SdkMessageProcessingStepId;

		public System.Guid Id => step.Id;

		/// <summary>
		/// Unique identifier of the SDK message processing step.
		/// </summary>
		public System.Nullable<System.Guid> SdkMessageProcessingStepIdUnique => step.SdkMessageProcessingStepIdUnique;

		/// <summary>
		/// Unique identifier of the Sdk message processing step secure configuration.
		/// </summary>
		//public Microsoft.Xrm.Sdk.EntityReference SdkMessageProcessingStepSecureConfigId => step.SdkMessageProcessingStepSecureConfigId;
		public EntityReferenceDisplay SdkMessageProcessingStepSecureConfigId => new EntityReferenceDisplay(step.SdkMessageProcessingStepSecureConfigId);

		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		public System.Nullable<System.Guid> SolutionId => step.SolutionId;

		/// <summary>
		/// Stage in the execution pipeline that the SDK message processing step is in.
		/// </summary>
		public sdkmessageprocessingstep_stage? Stage => step.Stage;

		/// <summary>
		/// Status of the SDK message processing step.
		/// </summary>
		public sdkmessageprocessingstep_statecode? StateCode => step.StateCode;

		/// <summary>
		/// Reason for the status of the SDK message processing step.
		/// </summary>
		public sdkmessageprocessingstep_statuscode? StatusCode => step.StatusCode;

		/// <summary>
		/// Deployment that the SDK message processing step should be executed on; server, client, or both.
		/// </summary>
		public sdkmessageprocessingstep_supporteddeployment? SupportedDeployment => step.SupportedDeployment;

		/// <summary>
		/// Number that identifies a specific revision of the SDK message processing step. 
		/// </summary>
		public System.Nullable<long> VersionNumber => step.VersionNumber;

		/// <summary>
		/// N:1 plugintype_sdkmessageprocessingstep
		/// </summary>
		internal mho.PluginStepsViewer.EarlyBoundTypes.PluginType plugintype_sdkmessageprocessingstep => step.plugintype_sdkmessageprocessingstep;

		/// <summary>
		/// N:1 plugintypeid_sdkmessageprocessingstep
		/// </summary>
		internal mho.PluginStepsViewer.EarlyBoundTypes.PluginType plugintypeid_sdkmessageprocessingstep => step.plugintypeid_sdkmessageprocessingstep;

		/// <summary>
		/// Type of entity with which the SDK message filter is primarily associated.
		/// </summary>
		public string PrimaryObjectTypeCode => step.PrimaryObjectTypeCode;

		/// <summary>
		/// Type of entity with which the SDK message filter is secondarily associated.
		/// </summary>
		public string SecondaryObjectTypeCode => step.SecondaryObjectTypeCode;
	}
}

