using UnityEngine;
using UnityEngine.UI;

public class MouseSensitivitySettings : MonoBehaviour
{
	[SerializeField]
	private Slider slider;

	[SerializeField]
	private InputField inputField;

	[SerializeField]
	private float interval;

	[SerializeField]
	private float mouseSensitivityMaxModifier;

	[SerializeField]
	private float mouseSensitivityMinModifier;

	private const float middleValue = 50f;

	private float mouseSensitivity;

	private void Start()
	{
	}

	public void SyncMouseSensitivity()
	{
	}

	public void SliderValueChanged()
	{
	}

	public void InputFieldValueChanged()
	{
	}

	private float CalculateMouseSensitivityValueFromValue(float value)
	{
		return 0f;
	}

	private float CalculateSliderValueFromMouseSensitivityValue()
	{
		return 0f;
	}

	private float RoundValue(float value)
	{
		return 0f;
	}
}
