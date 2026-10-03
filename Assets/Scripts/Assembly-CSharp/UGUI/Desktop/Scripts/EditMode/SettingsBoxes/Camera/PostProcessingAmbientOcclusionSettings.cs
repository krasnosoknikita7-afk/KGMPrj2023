using System.Collections.Generic;
using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public struct PostProcessingAmbientOcclusionSettings
	{
		public readonly bool ambientOcclusion;

		public readonly int intensity;

		public readonly int thickness;

		public readonly Color color;

		public PostProcessingAmbientOcclusionSettings(Dictionary<object, object> data)
		{
			ambientOcclusion = false;
			intensity = 0;
			thickness = 0;
			color = default;
		}
	}
}
