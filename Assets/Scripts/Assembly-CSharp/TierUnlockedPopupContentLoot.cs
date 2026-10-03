using MV.Common;
using UnityEngine.Events;

public class TierUnlockedPopupContentLoot : TierUnlockedPopupContentBase
{
	private GamePassTier unlockedGamePassTier;

	public override void Initialize(GamePassTier unlockedGamePassTier, UnityAction onDisplayDoneCallback)
	{
	}

	private void UpdateItemAmountText()
	{
	}

	private int GetItemAmount()
	{
		return 0;
	}

	private bool IsTierItemALootItem(MVWorldObjectClient item)
	{
		return false;
	}
}
