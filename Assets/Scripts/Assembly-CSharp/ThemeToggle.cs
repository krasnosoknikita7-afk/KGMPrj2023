using System;
using ThemeAttributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThemeToggle : BoolAttribute.Setter, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	protected Text label;

	[SerializeField]
	private SettingsToggle toggle;

	private Action<bool> onChange;

	public override void Initialize(BoolAttribute attrib, Action<bool> onChange)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
