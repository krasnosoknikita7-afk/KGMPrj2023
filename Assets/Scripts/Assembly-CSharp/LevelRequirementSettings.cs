using UnityEngine;
using UnityEngine.EventSystems;

public class LevelRequirementSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	public const string DataKey = "levelAmount";

	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider slider;

	[SerializeField]
	private SettingsInputFieldSlider inputField;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
