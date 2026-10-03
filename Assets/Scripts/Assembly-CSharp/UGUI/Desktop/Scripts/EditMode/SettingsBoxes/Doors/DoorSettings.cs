using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Doors
{
	public class DoorSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
	{
		[SerializeField]
		private SettingsBase settingsBase;

		[SerializeField]
		private SettingsInputField nameInputField;

		[SerializeField]
		private SettingsToggle toggleBeginOpen;

		[SerializeField]
		private SettingsToggle togglePlayersCanOpen;

		[SerializeField]
		private SettingsToggle toggleReverseOpenDirection;

		public void Initialize(int woID, GameObject root)
		{
		}

		public void OnSettingChanged(string key, object value)
		{
		}

		private Dictionary<object, object> ReadWorldObjectData(Dictionary<object, object> woData)
		{
			return null;
		}
	}
}
