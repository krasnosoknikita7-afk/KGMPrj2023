using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointLightSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	private float[] color;

	private int intType;

	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider colorR;

	[SerializeField]
	private SettingsSlider colorG;

	[SerializeField]
	private SettingsSlider colorB;

	[SerializeField]
	private SettingsSlider range;

	[SerializeField]
	private SettingsSlider intensity;

	[SerializeField]
	private SettingsSlider HaloTextures;

	[SerializeField]
	private SettingsToggle hide;

	[SerializeField]
	private Image preview;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
