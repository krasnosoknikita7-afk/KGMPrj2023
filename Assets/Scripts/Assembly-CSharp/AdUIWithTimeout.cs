using System;
using Assets.Scripts.AdIntegration;
using UnityEngine;

public class AdUIWithTimeout : MonoBehaviour, IAdUIManager
{
	[SerializeField]
	private ShowingAdsPopup showingAdPopup;

	private const float Timeout = 10f;

	private bool popupShowing;

	private bool wantsToPop;

	private GameObject overlayPushedToStack;

	private InterstitialAdResult interstitialResultLatePop;

	private RewardedAdResult rewardedAdResultLatePop;

	private Action<InterstitialAdResult> interstitialCallback;

	private Action<RewardedAdResult> rewardedCallback;

	public bool AdShowing()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void ShowInterstitial(Action<InterstitialAdResult> callbackFunction)
	{
	}

	public void ShowRewardedVideo(Action<RewardedAdResult> callbackFunction)
	{
	}

	public void PopInterstitial(InterstitialAdResult adResult)
	{
	}

	public void PopRewardedVideo(RewardedAdResult adResult)
	{
	}

	private void TryPopOverlay()
	{
	}

	private void CreatePopup()
	{
	}

	private void OnSkipClicked()
	{
	}
}
