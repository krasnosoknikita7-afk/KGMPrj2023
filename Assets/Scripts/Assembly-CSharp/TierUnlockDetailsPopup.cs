using System.Collections.Generic;
using Assets.Scripts.AdIntegration;
using MV.Common;
using MV.WorldObject.GamePassSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TierUnlockDetailsPopup : MonoBehaviour
{
	[SerializeField]
	private Text tierText;

	[SerializeField]
	private Text priceText;

	[SerializeField]
	private ProgressBar tierProgressBar;

	[SerializeField]
	private Text progressText;

	[SerializeField]
	private GameObject progressBarDivider;

	[SerializeField]
	private GameObject freeTryButton;

	[SerializeField]
	private GamePassesShop gamePassesShopPrefab;

	[SerializeField]
	private TierPurchaseNotEnoughGoldErrorPopup tierPurchaseGoldErrorPopupPrefab;

	[SerializeField]
	private TierUnlockedPopupController TierUnlockedPopupControllerPrefab;

	[SerializeField]
	private Image buttonIcon;

	private GamePassTier tierToPurchase;

	private int price;

	private UnityAction OnPurchaseSuccessful;

	private bool isWaitingForFreeTryTier;

	private bool isSubscribed;

	public void Initialize(GamePassTier tierToPurchase, int price, UnityAction OnPurchaseSuccessful)
	{
	}

	public void ShowTier()
	{
	}

	public void Purchase()
	{
	}

	public void OnClickFreeTryAd()
	{
	}

	public void OnClickFreeTrySubscriber()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void ProductPurchaseResponseHandler(int returnCode, Dictionary<object, object> purchaseResponseData)
	{
	}

	private void ShowTierUnlock(bool wasPurchased, bool wasTempUnlocked)
	{
	}

	private void HandleSuccessfulPurchase()
	{
	}

	private void UpdateTierProgressBar()
	{
	}

	private int ReduceGamePointsWithPreviousTierRequirements(GamePassTier gamePassTierToDisplay, int gamePoints, Dictionary<GamePassTier, PlayerTierState> gameTierShopStatus)
	{
		return 0;
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
