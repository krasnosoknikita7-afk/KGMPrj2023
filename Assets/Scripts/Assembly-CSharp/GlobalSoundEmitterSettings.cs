using UnityEngine;
using UnityEngine.EventSystems;

public class GlobalSoundEmitterSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	private class Keys
	{
		public enum Key
		{
			volume = 0,
			pitch = 1
		}

		private readonly string[] keys;

		public string this[Key key] => null;
	}

	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider volumeSlider;

	[SerializeField]
	private SettingsSlider pitchSlider;

	private Keys keys;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}

	public void OnSettingChanged(string key, int value)
	{
	}

	public void OnSettingChanged(string key, float value)
	{
	}
}
