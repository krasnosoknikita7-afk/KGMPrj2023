using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SettingsButton : MonoBehaviour
{
	[SerializeField]
	private Button button;

	private string key;

	private int value;

	public void Initialize(string key, int value)
	{
	}

	private void ValueChanged()
	{
	}
}
