using UnityEngine;
using UnityEngine.EventSystems;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes
{
	public class RewardedAdRequirementSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
	{
		public const string DataKey = "rewardedAd";

		[SerializeField]
		private SettingsBase settingsBase;

		[SerializeField]
		private SettingsToggle toggle;

		public void Initialize(int woID, GameObject root)
		{
		}

		public void OnSettingChanged(string key, object value)
		{
		}
	}
}
