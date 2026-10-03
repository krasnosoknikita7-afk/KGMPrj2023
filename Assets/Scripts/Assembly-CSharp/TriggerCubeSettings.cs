using UnityEngine;
using UnityEngine.EventSystems;

public class TriggerCubeSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider ScaleX;

	[SerializeField]
	private SettingsInputFieldSlider ScaleXInput;

	[SerializeField]
	private SettingsSlider ScaleY;

	[SerializeField]
	private SettingsInputFieldSlider ScaleYInput;

	[SerializeField]
	private SettingsSlider ScaleZ;

	[SerializeField]
	private SettingsInputFieldSlider ScaleZInput;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
