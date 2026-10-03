using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class SettingsInputFieldSlider : MonoBehaviour
{
	[SerializeField]
	private InputField inputField;

	[SerializeField]
	private SettingsSlider settingsSlider;

	[SerializeField]
	private bool round;

	private string key;

	public InputField InputField => null;

	public Slider Slider => null;

	public void SetText(string text)
	{
	}

	public void Initialize(string key, float value)
	{
	}

	public void Initialize(string key, int value)
	{
	}

	private void Update()
	{
	}

	public void SliderValueChanged()
	{
	}

	private static string ConvertFloatToString(float inputFieldValue)
	{
		return null;
	}

	public void InputFieldValueChanged()
	{
	}

	private float ConvertStringToFloat(string inputFieldText)
	{
		return 0f;
	}

	private void ValueChanged(string value)
	{
	}

	private void Reset()
	{
	}

	private float GetInputFieldValue(float value)
	{
		return 0f;
	}
}
