using System.Collections.Generic;
using MV.Common;

public class GameTierShopRepository
{
	private Dictionary<GamePassTier, Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>>> tierShopData;

	public Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> GetTierItemData(GamePassTier tier)
	{
		return null;
	}

	public void AddItemToTierShop(GamePassTier tier, MVWorldObjectDocumentationType documentationType, MVWorldObjectClient worldObject)
	{
	}

	public void RemoveItemToTierShop(GamePassTier tier, MVWorldObjectDocumentationType documentationType, int woid)
	{
	}
}
