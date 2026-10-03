using UnityEngine;
using UnityEngine.EventSystems;

public class WindTurbineSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider pitchSlider;

	[SerializeField]
	private SettingsInputFieldSlider pitchInputField;

	[SerializeField]
	private SettingsSlider powerSlider;

	[SerializeField]
	private SettingsInputFieldSlider powerInputField;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
