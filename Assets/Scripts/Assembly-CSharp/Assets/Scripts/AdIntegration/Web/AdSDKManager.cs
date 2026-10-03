using System;

namespace Assets.Scripts.AdIntegration.Web
{
	public class AdSDKManager : IAdManager
	{
		private Action<InterstitialAdResult> interstitialCallback;

		private Action<RewardedAdResult> rewardedCallback;

		private IAdSDK adSDK;

		private bool wasInitializedSuccessfully;

		public Type AdSDKType => null;

		public bool WasInitializedSuccessfully => false;

		public string RewardedAdNotAvailableText => null;

		public TimeSpan TimeSinceLastAd => default;

		public TimeSpan TimeSinceLastInterstitial => default;

		public TimeSpan TimeSinceLastRewarded => default;

		public bool ReadyForRewardedAdRequest => false;

		public bool ReadyForInterstitialAdRequest => false;

		public AdSDKManager(EmbeddedSite site)
		{
		}

		private void OnAdSDKInitReady()
		{
		}

		public void RequestInterstitial(Action<InterstitialAdResult> interstitialCallback, AdContext context)
		{
		}

		public void RequestRewardedAd(Action<RewardedAdResult> rewardedAdCallback, AdContext context)
		{
		}

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
	}
}
