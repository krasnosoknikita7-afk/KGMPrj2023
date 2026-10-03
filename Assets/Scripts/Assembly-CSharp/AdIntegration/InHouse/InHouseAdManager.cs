using System;
using Assets.Scripts.AdIntegration;

namespace AdIntegration.InHouse
{
	public class InHouseAdManager : IAdManager
	{
		private InHouseAdController inHouseAdController;

		private bool rewarded;

		private Action<RewardedAdResult> rewardCallback;

		private Action<InterstitialAdResult> interstitialCallback;

		private AdContext adContext;

		private bool timeoutAsEnabled;

		private int timeoutSuccessDelay;

		public string RewardedAdNotAvailableText => null;

		public TimeSpan TimeSinceLastAd => default;

		public TimeSpan TimeSinceLastInterstitial => default;

		public TimeSpan TimeSinceLastRewarded => default;

		public bool ReadyForRewardedAdRequest { get; private set; }

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

		private void OnRewardedFinished(bool obj)
		{
		}

		private void OnAdFinished()
		{
		}

		private void OnInterstitialFinished(bool obj)
		{
		}

		public void RequestInterstitial(Action<InterstitialAdResult> callback, AdContext context)
		{
		}

		private void PrepareAd(bool reward, AdContext context)
		{
		}

		public void InitializeAdController(InHouseAdController controller)
		{
		}

		private void UpdateInitStatus()
		{
		}
	}
}
