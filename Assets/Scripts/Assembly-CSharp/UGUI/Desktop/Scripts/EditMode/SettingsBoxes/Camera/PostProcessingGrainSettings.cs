using System.Collections.Generic;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public readonly struct PostProcessingGrainSettings
	{
		public readonly bool grain;

		public readonly int intensity;

		public readonly int size;

		public readonly int luminanceContribution;

		public PostProcessingGrainSettings(Dictionary<object, object> data)
		{
			grain = false;
			intensity = 0;
			size = 0;
			luminanceContribution = 0;
		}
	}
}
