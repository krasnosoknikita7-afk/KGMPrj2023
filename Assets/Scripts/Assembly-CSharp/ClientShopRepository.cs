using System.Collections.Generic;
using MV.WorldObject;

public class ClientShopRepository
{
	private readonly Dictionary<int, List<ShopItem>> repository;

	public readonly Dictionary<InventoryCategoryType, string> categories;

	public void AddItem(ShopItem item)
	{
	}

	public void RemoveItem(ShopItem item)
	{
	}

	public List<ShopItem> GetItemsInCategory(InventoryCategoryType category)
	{
		return null;
	}

	public List<ShopItem> GetItemsInCategorySlow(string category)
	{
		return null;
	}

	public string GetCategoryStringFromId(InventoryCategoryType category)
	{
		return null;
	}

	public int CategoryItemCount(InventoryCategoryType category)
	{
		return 0;
	}

	public bool GetItemByWorldObjectTypeInCategory(InventoryCategoryType inventoryCategory, WorldObjectType wo, out ShopItem item)
	{
		item = null;
		return false;
	}

	public bool IsItemShopInventory(string itemName, InventoryCategoryType inventoryCategory)
	{
		return false;
	}

	public void ReorganizeBySlotPositions()
	{
	}
}
