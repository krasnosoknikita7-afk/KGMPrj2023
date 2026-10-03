using System.Collections.Generic;
using Assets.Scripts.AdIntegration;
using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class GamePassesProgressBarFreeTryHandler : MonoBehaviour
{
	[SerializeField]
	private GameTierProgressBar tierProgressBar;

	[SerializeField]
	private TierUnlockedPopupController TierUnlockedPopupControllerPrefab;

	[SerializeField]
	private GamePassesShop gamePassesShopPrefab;

	[SerializeField]
	private List<Image> buttonAdImages;

	private GamePassTier tierToTry;

	private bool isWaitingForFreeTryTier;

	private void OnEnable()
	{
	}

	public void OnFreeTryTier(int tierToTry)
	{
	}

	private void ShowTierUnlock(bool wasPurchased, bool wasTempUnlocked)
	{
	}

	private void ShowAd()
	{
	}

	private void RewardedAdCallback(RewardedAdResult result)
	{
	}

	private void PreviewTier()
	{
	}

	private void OnPlayerPlanetDataUpdated()
	{
	}
}
