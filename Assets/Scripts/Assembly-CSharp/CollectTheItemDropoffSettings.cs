using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CollectTheItemDropoffSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsToggle toggle;

	private Dictionary<object, object> childMap;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
