using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovablesSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider slider;

	[SerializeField]
	private SettingsInputFieldSlider inputField;

	private Dictionary<object, object> blueprintData;

	private MVMovingPlatformGroup platformGroup;

	private bool successfullyInitialized;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
