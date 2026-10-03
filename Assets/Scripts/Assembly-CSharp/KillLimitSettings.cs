using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class KillLimitSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider killLimitSlider;

	[SerializeField]
	private SettingsInputFieldSlider killLimitInputField;

	[SerializeField]
	private Text killLimitHeader;

	public void Initialize(int woID, GameObject root, string header)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
