using System.Collections.Generic;
using MV.Common;
using MV.WorldObject.GamePassSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TierLockedDetailsPopup : MonoBehaviour
{
	[SerializeField]
	private Text tierText;

	[SerializeField]
	private Text headerText;

	[SerializeField]
	private Text lockedDescriptionText;

	[SerializeField]
	private Text lockedButtonText;

	[SerializeField]
	private ProgressBar tierProgressBar;

	[SerializeField]
	private Text progressText;

	[SerializeField]
	private GamePassesShop gamePassesShopPrefab;

	[SerializeField]
	private TierUnlockDetailsPopup tierUnlockDetailsPrefab;

	private GamePassTier tierToPurchase;

	private UnityAction onPurchaseSuccessful;

	public void Initialize(GamePassTier tierToPurchase, UnityAction OnPurchaseSuccessful)
	{
	}

	public void ShowTier()
	{
	}

	public void ShowLockedTier()
	{
	}

	private void UpdateLockedText()
	{
	}

	private string GetHeaderText()
	{
		return null;
	}

	private string GetLockedButtonText()
	{
		return null;
	}

	private string GetLockedDescription()
	{
		return null;
	}

	private GamePassTier GetLockedTier()
	{
		return GamePassTier.Tier0;
	}

	private void UpdateTierProgressBar()
	{
	}

	private int ReduceGamePointsWithPreviousTierRequirements(GamePassTier gamePassTierToDisplay, int gamePoints, Dictionary<GamePassTier, PlayerTierState> gameTierShopStatus)
	{
		return 0;
	}

	private void OnEnable()
	{
	}

	private void ShowPurchasePopup()
	{
	}
}
