using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MessageBoxSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	public const string TextKey = "text";

	public const string TextSizeKey = "textSize";

	public const string TextColorKey = "textColor";

	public const string BillboardKey = "billboard";

	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider sizeSlider;

	[SerializeField]
	private Text sizeLabel;

	[SerializeField]
	private SettingsInputField inputField;

	[SerializeField]
	private SettingsSlider colorR;

	[SerializeField]
	private SettingsSlider colorG;

	[SerializeField]
	private SettingsSlider colorB;

	[SerializeField]
	private Image preview;

	[SerializeField]
	private SettingsToggle billboardToggle;

	private float[] color;

	public static readonly float[] defaultColor;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}

	private static object RemoveQuadFromText(string key, object val)
	{
		return null;
	}

	private void SetTextSize(float value)
	{
	}
}
