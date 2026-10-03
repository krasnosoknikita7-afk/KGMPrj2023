using System;
using ThemeAttributes;
using UnityEngine;
using UnityEngine.UI;

public class ThemeDayNightCycleColorPresetSetter : IntAttribute.Setter
{
	[SerializeField]
	private DayNightCycleColorPresets colorPresets;

	[SerializeField]
	private Text settingNameLabel;

	[SerializeField]
	private Text presetNameLabel;

	private Action<int> onChange;

	private int colorPresetIndex;

	public override void Initialize(IntAttribute attrib, Action<int> onChange)
	{
	}

	public void Decrement()
	{
	}

	public void Increment()
	{
	}

	private int Constrain(int value)
	{
		return 0;
	}

	public void OnSettingChanged()
	{
	}
}
