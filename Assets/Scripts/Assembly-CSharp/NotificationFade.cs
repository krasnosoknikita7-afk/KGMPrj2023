using System;
using UnityEngine;

public class NotificationFade : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup group;

	[SerializeField]
	private AnimationCurve textVisibilityCurve;

	[SerializeField]
	private float duration;

	[SerializeField]
	private bool playing;

	private float currentTime;

	private float pauseAt;

	private bool shouldHideWhenDone;

	public Action OnFinished;

	public bool IsPaused => false;

	public bool ShouldHideWhenDone
	{
		set
		{
		}
	}

	public void Deactivate()
	{
	}

	public void Activate()
	{
	}

	public void PauseAt(float pausePoint)
	{
	}

	public void Unpause()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}
}
