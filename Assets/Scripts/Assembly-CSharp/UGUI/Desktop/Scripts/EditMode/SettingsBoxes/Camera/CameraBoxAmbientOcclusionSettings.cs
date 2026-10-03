using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public class CameraBoxAmbientOcclusionSettings : MonoBehaviour
	{
		public static class DataKeys
		{
			public const string AmbientOcclusionOn = "ppAOOn";

			public const string Intensity = "ppAOInty";

			public const string Thickness = "ppAOThick";

			public const string ColorR = "ppAOColR";

			public const string ColorG = "ppAOColG";

			public const string ColorB = "ppAOColB";
		}

		public static class DefaultValues
		{
			public const bool AmbientOcclusionOn = false;

			public const int Intensity = 0;

			public const int Thickness = 1;

			public const float ColorR = 0f;

			public const float ColorG = 0f;

			public const float ColorB = 0f;
		}

		private static class MinMaxValues
		{
			public const int IntensityMin = 0;

			public const int IntensityMax = 15;

			public const int ThicknessMin = 1;

			public const int ThicknessMax = 10;
		}

		[SerializeField]
		private CameraBoxSettings cameraBoxSettings;

		[SerializeField]
		private SettingsToggle featureOnToggle;

		[SerializeField]
		private SettingsSlider intensitySlider;

		[SerializeField]
		private SettingsInputFieldSlider intensityInputField;

		[SerializeField]
		private SettingsSlider thicknessSlider;

		[SerializeField]
		private SettingsInputFieldSlider thicknessInputField;

		[SerializeField]
		private Image colorImage;

		[SerializeField]
		private GameObject colorPicker;

		[SerializeField]
		private Image colorPickerPreview;

		[SerializeField]
		private SettingsSlider colorR;

		[SerializeField]
		private SettingsSlider colorG;

		[SerializeField]
		private SettingsSlider colorB;

		private void Start()
		{
		}

		public void OnSavePressed()
		{
		}

		public void OnColorPressed()
		{
		}

		public void OnColorEdited()
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
