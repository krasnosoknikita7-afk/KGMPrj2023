using System.Collections.Generic;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public struct PostProcessingColorSettings
	{
		public readonly bool colors;

		public readonly int postExposure;

		public readonly int temperature;

		public readonly int saturation;

		public readonly int contrast;

		public PostProcessingColorSettings(Dictionary<object, object> data)
		{
			colors = false;
			postExposure = 0;
			temperature = 0;
			saturation = 0;
			contrast = 0;
		}
	}
}
