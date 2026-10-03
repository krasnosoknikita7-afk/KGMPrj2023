using System.Collections.Generic;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public readonly struct PostProcessingLensDistortionSettings
	{
		public readonly bool lensDistortion;

		public readonly int intensity;

		public readonly int xMultiplier;

		public readonly int yMultiplier;

		public PostProcessingLensDistortionSettings(Dictionary<object, object> data)
		{
			lensDistortion = false;
			intensity = 0;
			xMultiplier = 0;
			yMultiplier = 0;
		}
	}
}
