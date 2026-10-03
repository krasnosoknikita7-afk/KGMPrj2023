using UnityEngine;
using UnityEngine.EventSystems;

public class StarsRequirementSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider slider;

	[SerializeField]
	private SettingsInputFieldSlider inputField;

	[SerializeField]
	private GameObject message;

	private AllCollectiblesCollectedClient collectible;

	private int maxValue;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}

	private void UpdateMaxValue()
	{
	}

	private void UpdateMessage(int starAmount)
	{
	}
}
