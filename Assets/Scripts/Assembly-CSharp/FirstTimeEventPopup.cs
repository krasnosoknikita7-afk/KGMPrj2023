using System;
using UnityEngine;
using UnityEngine.UI;

public class FirstTimeEventPopup : MonoBehaviour
{
	[SerializeField]
	private Button skipButton;

	[SerializeField]
	private FirstTimeFadeHandler fader;

	public void FadeIn()
	{
	}

	public void StartFade(Action<GameObject> finishedAction)
	{
	}

	public void StartFadeWithSelfPop()
	{
	}

	private void PopSelf(GameObject popupGameObject)
	{
	}

	public void SetSkippable(bool skipAllowed)
	{
	}
}
