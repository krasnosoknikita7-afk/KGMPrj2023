using UnityEngine;
using UnityEngine.EventSystems;

public class GamePointMinorRewardSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider gamePointsAwardedSlider;

	[SerializeField]
	private SettingsInputFieldSlider gamePointsAwardedInputField;

	private int woID;

	private const string gamePointAwardedString = "gamePointAmount";

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}

	private void UpdateData()
	{
	}

	private void OnDestroy()
	{
	}
}
