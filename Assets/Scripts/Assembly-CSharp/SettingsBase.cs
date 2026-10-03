using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsBase : MonoBehaviour
{
	public const string InfinitySign = "∞";

	[SerializeField]
	private Text headerText;

	private int woID;

	private Dictionary<object, object> result;

	public void Initialize(int woID, GameObject root, MVWorldObjectDocumentationType documentationType)
	{
	}

	public void Initialize(int woID, GameObject root, string header)
	{
	}

	private void OnPop()
	{
	}

	public void RemoveData(string key)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}

	private void Update()
	{
	}
}
