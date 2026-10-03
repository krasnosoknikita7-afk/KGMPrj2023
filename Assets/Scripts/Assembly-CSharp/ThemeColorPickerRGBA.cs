using System;
using ThemeAttributes;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThemeColorPickerRGBA : ThemeColorPickerRGB, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsSlider sliderA;

	protected override void Reset()
	{
	}

	public override void Initialize(ColorAttribute attrib, Action<Color> onChange)
	{
	}

	public override void OnSettingChanged(string key, object value)
	{
	}
}
