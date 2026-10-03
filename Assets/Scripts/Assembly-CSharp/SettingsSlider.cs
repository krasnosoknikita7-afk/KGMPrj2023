using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SettingsSlider : MonoBehaviour
{
	public Slider slider;

	public float interval;

	[SerializeField]
	private bool round;

	private string key;

	public float Value => 0f;

	public void Initialize(string key, float value, float minValue, float maxValue)
	{
	}

	public void Initialize(string key, int value, int minValue, int maxValue)
	{
	}

	public void ValueChanged()
	{
	}

	private void Reset()
	{
	}
}
