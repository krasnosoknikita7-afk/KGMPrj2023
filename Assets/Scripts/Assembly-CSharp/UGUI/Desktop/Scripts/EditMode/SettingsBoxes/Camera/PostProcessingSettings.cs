using System.Collections.Generic;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public struct PostProcessingSettings
	{
		public PostProcessingColorSettings colorSettings;

		public PostProcessingBloomSettings bloomSettings;

		public PostProcessingAmbientOcclusionSettings ambientOcclusionSettings;

		public PostProcessingDepthOfFieldSettings depthOfFieldSettings;

		public PostProcessingVignetteSettings vignetteSettings;

		public PostProcessingGrainSettings grainSettings;

		public PostProcessingLensDistortionSettings lensDistortionSettings;

		public PostProcessingSettings(Dictionary<object, object> data)
		{
			colorSettings = default;
			bloomSettings = default;
			ambientOcclusionSettings = default;
			depthOfFieldSettings = default;
			vignetteSettings = default;
			grainSettings = default;
			lensDistortionSettings = default;
		}
	}
}
