using UnityEngine;
using UnityEngine.EventSystems;

public class PulseBoxSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider enabledSlider;

	[SerializeField]
	private SettingsInputFieldSlider enabledInputField;

	[SerializeField]
	private SettingsSlider disabledSlider;

	[SerializeField]
	private SettingsInputFieldSlider disabledInputField;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
