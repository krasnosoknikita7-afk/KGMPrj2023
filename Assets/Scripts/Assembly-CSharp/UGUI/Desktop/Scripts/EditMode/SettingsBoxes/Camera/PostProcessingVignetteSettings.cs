using System.Collections.Generic;
using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public struct PostProcessingVignetteSettings
	{
		public readonly bool vignette;

		public readonly int intensity;

		public readonly int smoothness;

		public readonly int roundness;

		public readonly Color color;

		public readonly bool rounded;

		public PostProcessingVignetteSettings(Dictionary<object, object> data)
		{
			vignette = false;
			intensity = 0;
			smoothness = 0;
			roundness = 0;
			color = default;
			rounded = false;
		}
	}
}
