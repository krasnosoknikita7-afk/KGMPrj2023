using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PickHelper : MonoBehaviour
{
	public UnityAction<MVWorldObjectClient, MVWorldObjectClient> pickCallback;

	[SerializeField]
	private Text message;

	public void Initialize(UnityAction<MVWorldObjectClient, MVWorldObjectClient> onPickCallback, string msg)
	{
	}

	private void Update()
	{
	}

	private bool MVObjectIsType(Transform t, Type type, out int woId)
	{
		woId = default;
		return false;
	}
}
