using System.Collections.Generic;
using MV.WorldObject;

public class ShopRepository : ARepository
{
	private Dictionary<int, MVItem> shopInventory;

	public List<int> ItemCategoriesInShop;

	public IDictionary<int, MVItem> ShopInventory => null;

	public void ReorganizeItemsByItemType(bool notifyOfChange = false)
	{
	}

	public override void RemoveItem(int itemId)
	{
	}

	public Dictionary<int, MVItem> GetItemsByCategory(int itemCategory)
	{
		return null;
	}

	public Dictionary<int, MVItem> GetItemsByItemCategories(int[] itemCategories)
	{
		return null;
	}

	public void CreateWorldObjectHierarchies()
	{
	}
}
