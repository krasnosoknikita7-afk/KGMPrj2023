using System.Collections.Generic;
using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public class CameraBoxGrainSettings : MonoBehaviour
	{
		public static class DataKeys
		{
			public const string GrainOn = "ppGrainOn";

			public const string Intensity = "ppGrainInt";

			public const string Size = "ppGrainSize";

			public const string LuminanceContribution = "ppGrainLumCon";
		}

		public static class DefaultValues
		{
			public const bool Grain = false;

			public const int Intensity = 0;

			public const int Size = 10;

			public const int LuminanceContribution = 8;
		}

		private static class MinMaxValues
		{
			public const int IntensityMin = 0;

			public const int IntensityMax = 100;

			public const int SizeMin = 3;

			public const int SizeMax = 30;

			public const int LuminanceContributionMin = 0;

			public const int LuminanceContributionMax = 10;
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
		private SettingsSlider sizeSlider;

		[SerializeField]
		private SettingsInputFieldSlider sizeInputField;

		[SerializeField]
		private SettingsSlider luminanceContributionSlider;

		[SerializeField]
		private SettingsInputFieldSlider luminanceContributionInputField;

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
