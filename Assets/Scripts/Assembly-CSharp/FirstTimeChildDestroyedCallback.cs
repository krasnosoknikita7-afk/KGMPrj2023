using System;
using UnityEngine;

public class FirstTimeChildDestroyedCallback : MonoBehaviour
{
	private Action Destroyed;

	public void SubscribeToOnDestroyed(Action onDestroyed)
	{
	}

	private void OnDestroy()
	{
	}
}
