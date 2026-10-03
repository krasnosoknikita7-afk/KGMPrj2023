using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class SettingsToggle : MonoBehaviour
{
	[SerializeField]
	private Toggle toggle;

	private string key;

	public void Initialize(string key, bool value)
	{
	}

	private void ValueChanged(bool value)
	{
	}

	public bool IsSet()
	{
		return false;
	}
}
