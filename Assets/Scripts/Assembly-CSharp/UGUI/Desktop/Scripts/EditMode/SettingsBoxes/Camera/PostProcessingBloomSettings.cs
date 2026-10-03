using System.Collections.Generic;
using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public struct PostProcessingBloomSettings
	{
		public readonly bool bloom;

		public readonly int intensity;

		public readonly int softKnee;

		public readonly int diffusion;

		public readonly Color color;

		public PostProcessingBloomSettings(Dictionary<object, object> data)
		{
			bloom = false;
			intensity = 0;
			softKnee = 0;
			diffusion = 0;
			color = default;
		}
	}
}
