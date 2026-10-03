using UnityEngine;
using UnityEngine.EventSystems;

public class GamePointChestSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider gamePointsAwardedSlider;

	[SerializeField]
	private SettingsInputFieldSlider gamePointsAwardedInputField;

	private const string gamePointAwardedString = "gamePointAmount";

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
