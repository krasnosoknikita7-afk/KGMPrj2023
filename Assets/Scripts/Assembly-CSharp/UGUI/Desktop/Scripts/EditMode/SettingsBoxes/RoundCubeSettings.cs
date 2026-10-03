using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes
{
	public class RoundCubeSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
	{
		[SerializeField]
		private SettingsBase settingsBase;

		[SerializeField]
		private SettingsSlider slider;

		[SerializeField]
		private InputField minutes;

		[SerializeField]
		private InputField seconds;

		public void Initialize(int woID, GameObject root)
		{
		}

		public void OnSettingChanged(string key, object value)
		{
		}

		public void SliderChanged()
		{
		}

		public void OnInputFieldChanged()
		{
		}

		private int GetMinutes(string value)
		{
			return 0;
		}

		private int GetMinutes(int value)
		{
			return 0;
		}

		private int GetSeconds(string value)
		{
			return 0;
		}

		private int GetSeconds(int value)
		{
			return 0;
		}
	}
}
