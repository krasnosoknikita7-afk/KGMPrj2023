using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class GamePassesViewCrystalsInInventory : MonoBehaviour
{
	private List<ShopItem> buyingItems;

	private int pending;

	public void OnClickGetCrystals()
	{
	}

	private void HighlightObject(WorldObjectType worldObjectType)
	{
	}

	private int GetItemSlot(WorldObjectType worldObjectType)
	{
		return 0;
	}

	private void OnInventoryItemAdded(int category, int slot)
	{
	}

	private void TryPurchaseCrystalItems()
	{
	}

	private void PurchaseItem(WorldObjectType woType)
	{
	}

	private void OpenInventoryAtPosition(int categoryId, int itemSlot)
	{
	}

	private void PurchaseClientShopItem(ShopItem item)
	{
	}

	private void ProductPurchaseResponseHandler(int returnCode, Dictionary<object, object> data)
	{
	}
}
