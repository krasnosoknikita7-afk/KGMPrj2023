using System;
using ThemeAttributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThemeColorPickerRGB : ColorAttribute.Setter, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private Text label;

	[SerializeField]
	protected SettingsSlider sliderR;

	[SerializeField]
	protected SettingsSlider sliderG;

	[SerializeField]
	protected SettingsSlider sliderB;

	[SerializeField]
	protected RawImage previewImage;

	protected Action<Color> onChange;

	protected virtual void Reset()
	{
	}

	public override void Initialize(ColorAttribute attrib, Action<Color> onChange)
	{
	}

	public virtual void OnSettingChanged(string key, object value)
	{
	}

	protected void ChangeColor(Color c)
	{
	}
}
