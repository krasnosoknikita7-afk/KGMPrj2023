using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtonTouch : MonoBehaviour
{
	[SerializeField]
	private Image countdownFill;

	[SerializeField]
	private TimedPlayReward timedPlayReward;

	[SerializeField]
	protected bool shouldPop;

	[SerializeField]
	protected Button button;

	public Action OnPlayButtonPressed;

	public void Play()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPromotionShown(bool promotionShown, bool withAd)
	{
	}

	public virtual void OnConfirmPlay()
	{
	}

	private void Update()
	{
	}

	protected virtual void StartPlaying()
	{
	}

	protected virtual void OnCountdownEnd()
	{
	}
}
