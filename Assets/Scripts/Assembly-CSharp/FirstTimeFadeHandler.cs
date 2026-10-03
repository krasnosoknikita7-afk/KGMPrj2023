using System;
using UnityEngine;

public class FirstTimeFadeHandler : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private float fadeOutTime;

	private float currentFadeOutTime;

	[SerializeField]
	private float fadeInTime;

	private float currentFadeInTime;

	private bool fadingIn;

	private bool fadingOut;

	private Action<GameObject> finishedAction;

	private GameObject targetGameObject;

	public void StartFadeIn()
	{
	}

	public void StartFadeOut(Action<GameObject> finishedAction, GameObject targetGameObject)
	{
	}

	private void Update()
	{
	}

	private void DoAction()
	{
	}
}
