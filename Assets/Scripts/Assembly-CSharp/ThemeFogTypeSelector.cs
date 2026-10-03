using System;
using ThemeAttributes;
using UnityEngine;
using UnityEngine.UI;

public class ThemeFogTypeSelector : IntAttribute.Setter
{
	private class NamedFogMode
	{
		public FogMode Mode { get; set; }

		public string Name { get; set; }
	}

	[SerializeField]
	private Text settingNameLabel;

	[SerializeField]
	private Text presetNameLabel;

	private Action<int> onChange;

	private int modeIndex;

	private NamedFogMode[] availableModes;

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
