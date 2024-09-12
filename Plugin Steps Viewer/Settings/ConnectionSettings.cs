using System;
using XrmToolBox.Extensibility;

namespace mho.PluginStepsViewer
{
	/// <summary>
	/// Setting associated with a particular connection.
	/// </summary>
	public class ConnectionSettings
	{
		private Guid ConnectionId;

		public FilterSettings Assembly { get; set; }
		public FilterSettings Type { get; set; }
		public FilterSettings Name { get; set; }
		public FilterSettings Mode { get; set; }
		public FilterSettings Stage { get; set; }
		public FilterSettings Message { get; set; }
		public FilterSettings PrimaryEntity { get; set; }
		public FilterSettings SecondaryEntity { get; set; }

		public ConnectionSettings()
		{
		}

		public void SetMissingValuesToDefault()
		{
			if (Assembly == null)
				Assembly = FilterSettings.Default;

			if (Type == null)
				Type = FilterSettings.Default;

			if (Name == null)
				Name = FilterSettings.Default;

			if (Mode == null)
				Mode = FilterSettings.Default;

			if (Stage == null)
				Stage = FilterSettings.Default;

			if (Message == null)
				Message = FilterSettings.Default;

			if (PrimaryEntity == null)
				PrimaryEntity = FilterSettings.Default;

			if (SecondaryEntity == null)
				SecondaryEntity = FilterSettings.Default;
		}

		public static ConnectionSettings Read(Guid? connectionId)
		{
			ConnectionSettings settings = null;
			
			if (connectionId != null)
			{
				SettingsManager.Instance.TryLoad(
				typeof(PluginStepsViewerPlugin),
				out settings,
				connectionId.ToString());
			}

			if (settings == null)
				settings = new ConnectionSettings();

			settings.SetMissingValuesToDefault();
			settings.ConnectionId = connectionId.Value;
			return settings;
		}

		public static void Save(ConnectionSettings settings)
		{
			SettingsManager.Instance.Save(
				typeof(PluginStepsViewerPlugin),
				settings,
				settings.ConnectionId.ToString());
		}
	}
}
