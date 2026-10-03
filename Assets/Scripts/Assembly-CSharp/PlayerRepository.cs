using System.Collections.Generic;
using MV.WorldObject;

public class PlayerRepository : ARepository
{
	private Dictionary<int, MVItem> playerInventory;

	public IDictionary<int, MVItem> PlayerInventory => null;

	public override void RemoveItem(int itemId)
	{
	}

	public Dictionary<int, MVItem> GetItemsByItemCategory(int[] itemCategories)
	{
		return null;
	}

	public int CountItemsWithOriginalID(int originalId)
	{
		return 0;
	}

	public void CreateWorldObjectHierarchies()
	{
	}
}
