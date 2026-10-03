using UnityEngine;
using UnityEngine.EventSystems;

public class OculusSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	public static class Strings
	{
		public const string Radius = "Radius";

		public const string Speed = "Speed";

		public const string Lives = "Lives";
	}

	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider rangeSlider;

	[SerializeField]
	private SettingsSlider aggresionSlider;

	[SerializeField]
	private SettingsSlider numOfLivesSlider;

	[SerializeField]
	private SettingsInputFieldSlider numOfLivesInputSlider;

	private const int maxLives = 100;

	private MVWorldObjectClient target;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
