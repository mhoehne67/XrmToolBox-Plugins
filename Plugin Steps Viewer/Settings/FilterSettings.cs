namespace mho.PluginStepsViewer
{
	/// <summary>
	/// Stores the filter for a specific property.
	/// </summary>
	public class FilterSettings
	{
		public FilterOperator Operator { get; set; }
		public string Value { get; set; }

		public FilterSettings()
		{
		}

		public static FilterSettings Default
		{
			get
			{
				return new FilterSettings()
				{
					Operator = FilterOperator.Contains,
					Value = ""
				};
			}
		}
	}
}
