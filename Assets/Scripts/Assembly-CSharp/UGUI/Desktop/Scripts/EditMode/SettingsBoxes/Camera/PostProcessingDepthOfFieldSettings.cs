using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public readonly struct PostProcessingDepthOfFieldSettings
	{
		public readonly bool depthOfField;

		public readonly int focusDistance;

		public readonly int aperture;

		public readonly int focalLength;

		public readonly int maxBlurSize;

		public PostProcessingDepthOfFieldSettings(Dictionary<object, object> data)
		{
			depthOfField = false;
			focusDistance = 0;
			aperture = 0;
			focalLength = 0;
			maxBlurSize = 0;
		}

		public KernelSize KernelSize()
		{
			return UnityEngine.Rendering.PostProcessing.KernelSize.Small;
		}
	}
}
