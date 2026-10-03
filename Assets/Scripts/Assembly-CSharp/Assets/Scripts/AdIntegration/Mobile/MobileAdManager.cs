using System;
using GoogleMobileAds.Api;

namespace Assets.Scripts.AdIntegration.Mobile
{
	public class MobileAdManager : IAdManager, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
	{
		private class AdLoadState
		{
			private const int loadAttemptsMax = 0;

			public bool loadingAd;

			private int loadAttempts;

			public bool IsOk => false;

			public void ResetAttempts()
			{
			}

			public bool Reload()
			{
				return false;
			}

			public override string ToString()
			{
				return null;
			}
		}

		public class InternalStateInterstitial
		{
			private DateTime prevInterstitialTime;

			private readonly AdLoadState adLoadState;

			private InterstitialAdResult interstitialAdResult;

			private InterstitialAd interstitial;

			private bool isHandlingRequest;

			private Action<InterstitialAdResult> interstitialAdCallback;

			public TimeSpan TimeSinceLastInterstitial => default;

			public bool IsHandlingRequest => false;

			public bool IsOk => false;

			public void RequestInterstitialAd(Action<InterstitialAdResult> interstitialAdCallback)
			{
			}

			public void CreateAndLoadInterstitialAd()
			{
			}

			private void LoadInterstitialAd()
			{
			}

			private void SetupCallbacks()
			{
			}

			private void RemoveCallbacks()
			{
			}

			private void DestroyInterstitial()
			{
			}

			public void Destroy()
			{
			}

			private void HandleError()
			{
			}

			private void FinishRequest()
			{
			}

			public override string ToString()
			{
				return null;
			}

			private void ADLoadCallback(InterstitialAd ad, LoadAdError error)
			{
			}

			private void InterstitialOnOnAdFullScreenContentOpened()
			{
			}

			private void InterstitialOnOnAdFullScreenContentClosed()
			{
			}

			private void InterstitialOnOnAdClicked()
			{
			}

			private void InterstitialOnOnAdFullScreenContentFailed(AdError error)
			{
			}

			private void InterstitialOnOnAdImpressionRecorded()
			{
			}

			private void InterstitialOnOnAdPaid(AdValue adValue)
			{
			}
		}

		private class InternalStateRewardedAd
		{
			private DateTime prevInterstitialTime;

			private readonly AdLoadState adLoadState;

			private RewardedAdResult rewardAdResult;

			private Action<RewardedAdResult> rewardedAdCallback;

			private RewardedAd rewardedAd;

			private bool isHandlingRequest;

			public TimeSpan TimeSinceLastRewarded => default;

			public bool IsHandlingRequest => false;

			public bool IsOk => false;

			public void RequestRewardedAd(Action<RewardedAdResult> rewardedAdCallback)
			{
			}

			public void CreateAndLoadRewardedAd()
			{
			}

			private void LoadRewardedAd()
			{
			}

			private void SetupCallbacks()
			{
			}

			private void RemoveCallbacks()
			{
			}

			private void DestroyRewardedAd()
			{
			}

			public void Destroy()
			{
			}

			private void HandleRewardedAdLoaded(RewardedAd ad, LoadAdError error)
			{
			}

			private void UserRewardEarnedCallback(Reward reward)
			{
			}

			private void RewardedAdOnOnAdFullScreenContentOpened()
			{
			}

			private void RewardedAdOnOnAdFullScreenContentClosed()
			{
			}

			private void RewardedAdOnOnAdFullScreenContentFailed(AdError obj)
			{
			}

			private void RewardedAdOnOnAdImpressionRecorded()
			{
			}

			private void RewardedAdOnOnAdPaid(AdValue adValue)
			{
			}

			private void RewardedAdOnOnAdClicked()
			{
			}

			private void HandleError()
			{
			}

			private void FinishRequest()
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private class InterstitialAdResultHandler
		{
			public bool IsDone;

			private readonly Action<InterstitialAdResult> interstitialCallback;

			private InterstitialAdResult interstitialAdResult;

			private readonly IAdUIManager adUIManager;

			private readonly AdContext context;

			public InterstitialAdResultHandler(Action<InterstitialAdResult> interstitialCallback, IAdUIManager adUIManager, AdContext context)
			{
			}

			public void SetResult(InterstitialAdResult interstitialAdResult)
			{
			}

			public void DoCallBack()
			{
			}
		}

		private class RewardedAdResultHandler
		{
			public bool IsDone;

			private readonly Action<RewardedAdResult> rewardedAdCallback;

			private RewardedAdResult rewardedAdResult;

			private readonly IAdUIManager adUIManager;

			private readonly AdContext context;

			public RewardedAdResultHandler(Action<RewardedAdResult> rewardedAdCallback, IAdUIManager adUIManager, AdContext context)
			{
			}

			public void SetResult(RewardedAdResult rewardedAdResult)
			{
			}

			public void DoCallBack()
			{
			}
		}

		private class ConsentAndCompliance
		{
			private ConsentData consentData;

			public bool DoTagForChildDirectedTreatment => false;

			public bool TagForUnderAgeOfConsent => false;

			public bool HasConsented => false;

			public bool IsGDPRConsentRequired => false;

			public ConsentAndCompliance()
			{
			}

			public ConsentAndCompliance(ConsentData consentData)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private class InternalAdManagerState
		{
			private bool isReady;

			private InternalStateRewardedAd internalStateRewardedAds;

			private InternalStateInterstitial internalStateInterstitial;

			public TimeSpan TimeSinceLastAd => default;

			public TimeSpan TimeSinceLastInterstitial => default;

			public TimeSpan TimeSinceLastRewarded => default;

			public bool IsReady => false;

			public bool ReadyForRewardedAdRequest => false;

			public bool ReadyForInterstitialAdRequest => false;

			public bool IsHandlingRequest => false;

			public void Initialize()
			{
			}

			public void RequestRewardedAd(Action<RewardedAdResult> rewardedAdCallback)
			{
			}

			public void RequestInterstitial(Action<InterstitialAdResult> interstitialCallback)
			{
			}

			public void Destroy()
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private static ConsentAndCompliance consentAndCompliance;

		private bool isInitialized;

		private static bool testing;

		private RewardedAdResultHandler rewardedAdResultHandler;

		private InterstitialAdResultHandler interstitialAdResultHandler;

		private InternalAdManagerState internalAdManagerState;

		private IAdUIManager adUIManager;

		private bool timeoutAdAfterDelayAsUnlocked;

		private int timeoutSuccessDelay;

		private float timeOfRewardedAdStart;

		private float interstitialTimeoutAfterRewardedAd;

		private float lastSeenRewardedAd;

		public string RewardedAdNotAvailableText => null;

		public bool IsAdRunning => false;

		public TimeSpan TimeSinceLastAd => default;

		public TimeSpan TimeSinceLastInterstitial => default;

		public TimeSpan TimeSinceLastRewarded => default;

		public bool ReadyForRewardedAdRequest => false;

		public bool ReadyForInterstitialAdRequest => false;

		public MobileAdManager(bool testing)
		{
		}

		public void InitializeAdConfigSettings(AdConfigSettings config)
		{
		}

		public bool HideFullscreen()
		{
			return false;
		}

		public void Initialize()
		{
		}

		public void InitializeCallbackManager(IAdUIManager adUIManager)
		{
		}

		private void SetupConsentAndCompliance(ConsentData consentData)
		{
		}

		public void RequestRewardedAd(Action<RewardedAdResult> rewardedAdCallback, AdContext context)
		{
		}

		private void SendRewardRequestStats(AdContext context)
		{
		}

		public void RequestInterstitial(Action<InterstitialAdResult> interstitialCallback, AdContext context)
		{
		}

		private void SendInterstitialAdRequestStats(AdContext context)
		{
		}

		private void InterstitialCallback(InterstitialAdResult obj)
		{
		}

		private void RewardedAdCallback(RewardedAdResult obj)
		{
		}

		public void Destroy()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void UpdateControllerUpdate()
		{
		}

		private void SetConsent(ConsentAndCompliance cac)
		{
		}

		private void SetConsentVungle(ConsentAndCompliance cac)
		{
		}

		private void SetConsentAdColony(ConsentAndCompliance cac)
		{
		}

		private void SetConsentAppLovin(ConsentAndCompliance cac)
		{
		}

		private void SetConsentUnityAds(bool hasConsented)
		{
		}

		private void SetConsentIronSource(bool hasConsented)
		{
		}

		private static AdRequest CreateAdRequest()
		{
			return null;
		}

		private static void SendStat(string stat)
		{
		}

		private void InitCompleteAction(InitializationStatus initializationStatus)
		{
		}
	}
}
