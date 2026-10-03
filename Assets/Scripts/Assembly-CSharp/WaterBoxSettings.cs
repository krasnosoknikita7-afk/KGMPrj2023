using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WaterBoxSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider colorR;

	[SerializeField]
	private SettingsSlider colorG;

	[SerializeField]
	private SettingsSlider colorB;

	[SerializeField]
	private SettingsToggle toggle;

	[SerializeField]
	private Image preview;

	private float[] color;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}

	private void UpdateWaterColor()
	{
	}
}
