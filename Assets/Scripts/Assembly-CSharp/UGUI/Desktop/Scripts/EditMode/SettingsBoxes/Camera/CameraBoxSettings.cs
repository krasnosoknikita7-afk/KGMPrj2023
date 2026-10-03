using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera
{
	public class CameraBoxSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
	{
		public const string DistanceToAvatarDataKey = "distanceToAvatar";

		public const string ForceFirstPersonDataKey = "forceFirstPersonCamera";

		[SerializeField]
		private SettingsBase settingsBase;

		[SerializeField]
		private SettingsSlider slider;

		[SerializeField]
		private SettingsInputFieldSlider inputField;

		[SerializeField]
		private SettingsToggle toggle;

		[SerializeField]
		private CameraBoxColorsSettings colorsSettings;

		[SerializeField]
		private CameraBoxBloomSettings bloomSettings;

		[SerializeField]
		private CameraBoxAmbientOcclusionSettings ambientOcclusionSettings;

		[SerializeField]
		private CameraBoxDepthOfFieldSettings depthOfFieldSettings;

		[SerializeField]
		private CameraBoxVignetteSettings vignetteSettings;

		[SerializeField]
		private CameraBoxGrainSettings grainSettings;

		[SerializeField]
		private CameraBoxLensDistortionSettings lensDistortionSettings;

		private int cameraWorldObjectID;

		private Dictionary<object, object> woData;

		public void Initialize(int woID, GameObject root)
		{
		}

		private Dictionary<object, object> InitData()
		{
			return null;
		}

		public void OnSettingChanged(string key, object value)
		{
		}

		public void OnColorSettingsOpen()
		{
		}

		public void OnBloomSettingsOpen()
		{
		}

		public void OnAmbientOcclusionSettingsOpen()
		{
		}

		public void OnDepthOfFieldSettingsOpen()
		{
		}

		public void OnVignetteSettingsOpen()
		{
		}

		public void OnGrainSettingsOpen()
		{
		}

		public void OnLensDistortionSettingsOpen()
		{
		}

		public object GetSetting(string dataKey, object defaultVal)
		{
			return null;
		}
	}
}
