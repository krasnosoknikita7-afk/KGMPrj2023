using System.Collections.Generic;
using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public class CameraBoxColorsSettings : MonoBehaviour
	{
		public static class DataKeys
		{
			public const string ColorsOn = "ppColorsOn";

			public const string PostExposure = "ppColorsPExp";

			public const string Temperature = "ppColorsTemp";

			public const string Saturation = "ppColorsSatur";

			public const string Contrast = "ppColorContr";
		}

		public static class DefaultValues
		{
			public const bool Colors = false;

			public const int PostExposure = 0;

			public const int Temperature = 0;

			public const int Saturation = 0;

			public const int Contrast = 0;
		}

		private static class MinMaxValues
		{
			public const int PostExposureMin = -15;

			public const int PostExposureMax = 15;

			public const int TemperatureMin = -100;

			public const int TemperatureMax = 100;

			public const int SaturationMin = -100;

			public const int SaturationMax = 100;

			public const int ContrastMin = -40;

			public const int ContrastMax = 100;
		}

		[SerializeField]
		private CameraBoxSettings cameraBoxSettings;

		[SerializeField]
		private SettingsToggle colorsOnToggle;

		[SerializeField]
		private SettingsSlider postExposureSlider;

		[SerializeField]
		private SettingsInputFieldSlider postExposureInputField;

		[SerializeField]
		private SettingsSlider temperatureSlider;

		[SerializeField]
		private SettingsInputFieldSlider temperatureInputField;

		[SerializeField]
		private SettingsSlider saturationSlider;

		[SerializeField]
		private SettingsInputFieldSlider saturationInputField;

		[SerializeField]
		private SettingsSlider contrastSlider;

		[SerializeField]
		private SettingsInputFieldSlider contrastInputField;

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

		public static object ValueToSend(string key, object value)
		{
			return null;
		}
	}
}
