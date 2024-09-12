using System.ComponentModel;
using System;

namespace mho.PluginStepsViewer.Display
{
	/// <summary>
	/// Type converter for <see cref="EntityReferenceDisplay"/> objects.
	/// </summary>
	public class EntityReferenceTypeConverter : TypeConverter
	{
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return TypeDescriptor.GetProperties(typeof(EntityReferenceDisplay));
		}
	}
}

