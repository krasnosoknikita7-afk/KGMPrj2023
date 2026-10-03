using System.Collections.Generic;
using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public class CameraBoxDepthOfFieldSettings : MonoBehaviour
	{
		public static class DataKeys
		{
			public const string DepthOfFieldOn = "ppDofOn";

			public const string FocusDistance = "ppDofPFDist";

			public const string Aperture = "ppDofApert";

			public const string FocalLength = "ppDofFLen";

			public const string MaxBlurSize = "ppDofMBlur";
		}

		public static class DefaultValues
		{
			public const bool DepthOfField = false;

			public const int FocusDistance = 10;

			public const int Aperture = 56;

			public const int FocalLength = 50;

			public const int MaxBlurSize = 2;
		}

		private static class MinMaxValues
		{
			public const int FocusDistanceMin = 29;

			public const int FocusDistanceMax = 1500;

			public const int ApertureMin = 1;

			public const int ApertureMax = 320;

			public const int FocalLengthMin = 1;

			public const int FocalLengthMax = 300;

			public const int MaxBlurSizeMin = 1;

			public const int MaxBlurSizeMax = 4;
		}

		[SerializeField]
		private CameraBoxSettings cameraBoxSettings;

		[SerializeField]
		private SettingsToggle featureOnToggle;

		[SerializeField]
		private SettingsSlider focusDistanceSlider;

		[SerializeField]
		private SettingsInputFieldSlider focusDistanceInputField;

		[SerializeField]
		private SettingsSlider apertureSlider;

		[SerializeField]
		private SettingsInputFieldSlider apertureInputField;

		[SerializeField]
		private SettingsSlider focalLengthSlider;

		[SerializeField]
		private SettingsInputFieldSlider focalLengthInputField;

		[SerializeField]
		private SettingsSlider maxBlurSizeSlider;

		[SerializeField]
		private SettingsInputFieldSlider maxBlurSizeInputField;

		private void Start()
		{
		}

		public void OnSavePressed()
		{
		}

		public static void InitData(Dictionary<object, object> data)
		{
		}

		public static bool IsKey(string key)
		{
			return false;
		}

		public object ValueToSend(string key, object value)
		{
			return null;
		}
	}
}
