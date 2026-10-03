using System.Collections.Generic;
using MV.WorldObject;

public class MVItemBusinessLogic
{
	private Dictionary<int, MVItem> items;

	public void AddItem(MVItem item)
	{
	}

	public void AddItemWithNoData(int itemID, bool resellable, int itemCategoryID, int itemTypeID, string name)
	{
	}

	public MVItem GetItem(int itemID)
	{
		return null;
	}

	public bool CanAddItemToInventory(int itemID)
	{
		return false;
	}
}
