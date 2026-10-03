using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class TierUnlockedItemsPopup : MonoBehaviour
{
	[SerializeField]
	private Transform itemElementContainer;

	[SerializeField]
	private TierUnlockedItemElement tierUnlockedItemElementPrefab;

	public void Initialize(GamePassTier tier, Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> tierShopData)
	{
	}
}
