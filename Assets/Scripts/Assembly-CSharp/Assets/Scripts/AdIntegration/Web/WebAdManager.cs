using System;
using AdIntegration.InHouse;

namespace Assets.Scripts.AdIntegration.Web
{
	public class WebAdManager : IAdManager, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
	{
		private struct JSONAdReturnedData
		{
			public bool adAvailable;
		}

		private struct JSONInterstitialAdSuccessful
		{
			public bool status;
		}

		private struct JSONRewardedAdSuccessful
		{
			public bool status;

			public bool noReward;
		}

		private bool webReturnedAvailabilityInterstitial;

		private bool webReturnedAvailabilityRewardedAd;

		private const float RefreshTimer = 60f;

		private float updateTime;

		private readonly DateTime prevInterstitialTime;

		private IAdUIManager adUIManager;

		private IAdManager sdkManager;

		private IAdManager inHouseAdManager;

		private bool embeddedSiteSDKAvailable;

		private bool inHouseAdManagerAvailable;

		private EmbeddedSiteConfigData siteData;

		private bool probablyWatchingAd;

		private const float ProbablyWatchingAdDelay = 3f;

		private float probablyWatchingAdStarted;

		private AdContext currentAdType;

		private bool showingAd;

		private float timeOfRewardedAdStart;

		private bool timeoutAdAfterDelayAsUnlocked;

		private int timeoutSuccessDelay;

		private float interstitialTimeoutAfterRewardedAd;

		private float lastSeenRewardedAd;

		public EmbeddedSiteConfigData EmbeddedSiteConfig => default;

		public bool EmbeddedSiteSDKAvailable => false;

		public string RewardedAdNotAvailableText => null;

		public TimeSpan TimeSinceLastAd => default;

		public TimeSpan TimeSinceLastInterstitial => default;

		public TimeSpan TimeSinceLastRewarded => default;

		public bool ReadyForRewardedAdRequest => false;

		public bool ReadyForInterstitialAdRequest => false;

		public static void AdLog(Exception e)
		{
		}

		public static void AdLog(string msg)
		{
		}

		public void InitializeAdConfigSettings(AdConfigSettings config)
		{
		}

		public bool HideFullscreen()
		{
			return false;
		}

		public void InitializeCallbackManager(IAdUIManager adUIManager)
		{
		}

		public void CreateAdManagerHack()
		{
		}

		public void ForceCreateEmbeddedSiteSDK(EmbeddedSiteConfigData site)
		{
		}

		private void PrepareForAd(bool rewarded, AdContext context, Action onAdShowing, Action requestAd)
		{
		}

		public void RequestRewardedAd(Action<RewardedAdResult> rewardedAdCallback, AdContext context)
		{
		}

		private void StartedWatchingAd()
		{
		}

		private void SendRequestStats(bool rewarded, AdContext context)
		{
		}

		public void RequestInterstitial(Action<InterstitialAdResult> interstitialCB, AdContext context)
		{
		}

		private void InterstitialAdShownSDKCallback(InterstitialAdResult result)
		{
		}

		private void RewardedAdShownSDKCallback(RewardedAdResult result)
		{
		}

		private void RequestNonEmbeddedInterstitialAd()
		{
		}

		private void RequestNonEmbeddedRewardedAd()
		{
		}

		private void SetFinishedWatchingAd(string adType)
		{
		}

		private static void SendStat(string stat)
		{
		}

		public void UpdateControllerUpdate()
		{
		}

		private void OnInterstitialShownCallback(bool ok, string json)
		{
		}

		private void OnInHouseInterstitialAdShownCallback(InterstitialAdResult obj)
		{
		}

		private void OnRewardedAdShownCallback(bool ok, string json)
		{
		}

		private void RewardAdSuccess()
		{
		}

		private void OnInHouseRewardedAdShownCallback(RewardedAdResult obj)
		{
		}

		private void WebCallbackAdAvailable(bool ok, string jsonData)
		{
		}

		private void WebCallbackRewardedAdAvailable(bool ok, string jsonData)
		{
		}

		public void InitializeInHouse(InHouseAdController inHouseAdController)
		{
		}
	}
}
