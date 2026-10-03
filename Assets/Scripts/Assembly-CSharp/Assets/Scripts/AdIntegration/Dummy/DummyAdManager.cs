using System;

namespace Assets.Scripts.AdIntegration.Dummy
{
	public class DummyAdManager : IAdManager, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
	{
		private IAdUIManager adUIHandler;

		private float startTime;

		private readonly float delay;

		private bool rewarded;

		private bool timeoutAsEnabled;

		private int timeoutSuccessDelay;

		public string RewardedAdNotAvailableText => null;

		public TimeSpan TimeSinceLastAd => default;

		public TimeSpan TimeSinceLastInterstitial => default;

		public TimeSpan TimeSinceLastRewarded => default;

		public bool ReadyForRewardedAdRequest => false;

		public bool ReadyForInterstitialAdRequest => false;

		public void InitializeAdConfigSettings(AdConfigSettings config)
		{
		}

		public bool HideFullscreen()
		{
			return false;
		}

		public void InitializeCallbackManager(IAdUIManager handler)
		{
		}

		public void RequestRewardedAd(Action<RewardedAdResult> rewardedAdCallback, AdContext context)
		{
		}

		public void RequestInterstitial(Action<InterstitialAdResult> interstitialCallback, AdContext context)
		{
		}

		public void UpdateControllerUpdate()
		{
		}
	}
}
