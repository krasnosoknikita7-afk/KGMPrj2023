using UnityEngine;
using UnityEngine.EventSystems;

public class TimeTriggerSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider durationSlider;

	[SerializeField]
	private SettingsInputFieldSlider durationInputField;

	[SerializeField]
	private SettingsSlider delaySlider;

	[SerializeField]
	private SettingsInputFieldSlider delayInputField;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
