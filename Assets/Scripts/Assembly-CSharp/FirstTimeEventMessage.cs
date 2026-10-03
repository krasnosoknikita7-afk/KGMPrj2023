using System;
using UnityEngine;
using UnityEngine.UI;

public class FirstTimeEventMessage : MonoBehaviour
{
	[SerializeField]
	private FirstTimeFadeHandler fader;

	[SerializeField]
	private Text message;

	public void FadeIn()
	{
	}

	public void FadeOut(Action<GameObject> onFinished)
	{
	}

	public void SetText(string messageText)
	{
	}
}
