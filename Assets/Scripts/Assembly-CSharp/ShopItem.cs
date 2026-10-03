using System.Collections.Generic;

public class ShopItem
{
	public readonly int itemID;

	public readonly int itemCategoryID;

	public readonly int itemTypeID;

	public string name;

	public string description;

	public readonly byte[] data;

	public readonly bool resellable;

	public readonly int priceGold;

	public int slotPosition;

	public ShopItem(int key, Dictionary<object, object> outData)
	{
	}

	public ShopItem(InventoryItem inventoryItem)
	{
	}

	public void ApplyLocalDescriptionOverride(MVWorldObjectDocumentationType t)
	{
	}
}
