using System;
using Assets.Scripts.AdIntegration;
using UnityEngine;

public class AdUIOverlay : MonoBehaviour, IAdUIManager
{
	[SerializeField]
	private GameObject adBackground;

	private bool popupShowing;

	public bool AdShowing()
	{
		return false;
	}

	private void Awake()
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

	private void CreatePopup()
	{
	}

	private void Pop()
	{
	}
}
