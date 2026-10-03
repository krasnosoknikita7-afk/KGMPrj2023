using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class TierUnlockedAccessItemsRewardInfo : MonoBehaviour, IGamePassShopContent
{
	[SerializeField]
	private GameObject backgroundTier1;

	[SerializeField]
	private GameObject backgroundTier2;

	[SerializeField]
	private GameObject backgroundTier3;

	[SerializeField]
	private Text itemAmountText;

	[SerializeField]
	private TierUnlockAccessItemsPopup tierUnlockedItemsPopupPrefab;

	private GamePassTier tier;

	private Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> tierShopData;

	public void Initialize(GamePassTier tier, Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> tierShopData)
	{
	}

	public void OnSeeItemsButtonPressed()
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	private void ChangeBackground(GamePassTier tier)
	{
	}

	private void UpdateItemAmountText()
	{
	}
}
