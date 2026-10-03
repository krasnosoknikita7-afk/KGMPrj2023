using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SmokeSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	private float[] color;

	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider colorR;

	[SerializeField]
	private SettingsSlider colorG;

	[SerializeField]
	private SettingsSlider colorB;

	[SerializeField]
	private SettingsSlider alpha;

	[SerializeField]
	private SettingsSlider wind;

	[SerializeField]
	private SettingsSlider range;

	[SerializeField]
	private Image preview;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
