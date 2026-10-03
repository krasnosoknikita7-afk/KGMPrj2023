using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class SettingsDropdown : MonoBehaviour
{
	[SerializeField]
	private Dropdown dropdown;

	private string key;

	private List<int> possibleWOData;

	public void Initialize(string key, int value, string[] options, List<int> possibleWOData)
	{
	}

	private void ValueChanged(int value)
	{
	}

	private void Reset()
	{
	}
}
