using System;
using Assets.Scripts.AdIntegration;

public class TouristAdStateHandler
{
	private static readonly float adRateLimitTimer;

	private float adRateLimitCurrentTime;

	private Action OnAdShown;

	public void ShowAd(Action OnAdFinished)
	{
	}

	private void InterstitialCallback(InterstitialAdResult obj)
	{
	}
}
