using System.Collections.Generic;
using XrmToolBox.Extensibility;

namespace mho.PluginStepsViewer
{
	public class GlobalSettings
	{
		public static readonly List<string> DefaultExcludedAssemblies = new List<string>
		{
			"Microsoft",
			"ActivityAnalysisPlugins.",
			"ActivityFeeds.",
			"CRM.",
			"PluginProfiler.Plugins",
			"PreferredSolutionPlugins"
		};


	public List<string> ExcludedAssemblies { get; set; }

		public GlobalSettings()
		{
		}

		private void SetMissingValuesToDefault()
		{
			if (ExcludedAssemblies == null)
				ExcludedAssemblies = new List<string>(DefaultExcludedAssemblies);
		}

		public static GlobalSettings Read()
		{
			if (!SettingsManager.Instance.TryLoad(
				typeof(PluginStepsViewerPlugin),
				out GlobalSettings settings))
			{
				settings = new GlobalSettings();
			}

			settings.SetMissingValuesToDefault();
			return settings;
		}

		public static void Save(GlobalSettings settings)
		{
			SettingsManager.Instance.Save(
				typeof(PluginStepsViewerPlugin), 
				settings);
		}
	}
}
