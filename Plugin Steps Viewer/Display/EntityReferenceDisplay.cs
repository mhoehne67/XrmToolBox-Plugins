using Microsoft.Xrm.Sdk;
using System.ComponentModel;
using System;

namespace mho.PluginStepsViewer.Display
{
	/// <summary>
	/// Wrapper class to display EntityReference properties of a plugin step 
	/// in the property grid control. This will allow to expand such references
	/// and see its properties.
	/// </summary>
	[TypeConverter(typeof(EntityReferenceTypeConverter))]
	public class EntityReferenceDisplay
	{
		readonly EntityReference value;

		public EntityReferenceDisplay(EntityReference value)
		{
			this.value = value;
		}

		/// <summary>
		/// Gets or sets the ID of the record.
		/// </summary>
		public Guid? Id => value?.Id;

		/// <summary>
		/// Gets or sets the logical name of the entity.
		/// </summary>
		public string LogicalName => value?.LogicalName;

		/// <summary>
		/// Gets or sets the value of the primary attribute of the entity.
		/// </summary>
		public string Name => value?.Name;

		//
		// Summary:
		//     Gets or sets the key attributes.
		//
		// Returns:
		//     Type: Microsoft.Xrm.Sdk.KeyAttributeCollection.
		// public KeyAttributeCollection KeyAttributes => value?.KeyAttributes;

		//
		// Summary:
		//     Gets or sets the row version.
		//
		// Returns:
		//     Type: String.
		// public string RowVersion => value?.RowVersion;

		//
		// Summary:
		//     Gets or sets the structure that contains extra data.
		//
		// Returns:
		//     Type: ExtensionDataObjectThe extension data.
		//public ExtensionDataObject ExtensionData => value?.ExtensionData;

		public override string ToString()
		{			
			return Name;
		}
	}
}

