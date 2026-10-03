using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using MV.WorldObject;

namespace UGUI.Desktop.Scripts.EditMode.Inventories
{
	public class PlayerShopInventoryRepository
	{
		public Action OnFailedToAddItem;

		public Action OnInventoryChanged;

		public Action OnFailedToLoadItem;

		public Action<int, int, bool> OnInventoryItemAdded;

		public float ItemLoadingTick;

		private ClientShopRepository clientShopRepository { get; set; }

		private PlayerInventoryRepository playerInventoryRepository { get; set; }

		public Dictionary<InventoryCategoryType, string> InventoryCategories => null;

		public Dictionary<InventoryCategoryType, string> ShopCategories => null;

		public int ShopCategoryItemCount(InventoryCategoryType category)
		{
			return 0;
		}

		public List<ShopItem> GetShopItemsInCategorySlow(string category)
		{
			return null;
		}

		public void Setup(EventData photonEvent)
		{
		}

		public void RemoveItemFromInventory(int itemID)
		{
		}

		public void AddShopItems(Dictionary<object, object> outData, bool isDone)
		{
		}

		public void FailedToAddItem()
		{
		}

		public void AddItemToInventory(InventoryItem item)
		{
		}

		public void UpdatePlayerShopInventoryID(int itemID, int shopInventoryID)
		{
		}

		public int HighestSlotIndex(InventoryCategoryType categoryID)
		{
			return 0;
		}

		public InventoryItem AddPurchasedItem(ShopItem shopItem)
		{
			return null;
		}

		public bool HasShopWorldObjectType(WorldObjectType worldObjectType)
		{
			return false;
		}

		public void RemoveInventoryItem(InventoryItem previewedItem)
		{
		}

		public int CountInventoryItemsWithOriginalID(InventoryItem item)
		{
			return 0;
		}

		public List<InventoryItem> GetInventoryItemsInCategorySlow(string s)
		{
			return null;
		}

		public void SwapInventoryItemSlotPositions(InventoryItem source, InventoryItem destination)
		{
		}

		public string GetShopCategoryStringFromId(InventoryCategoryType inventoryCategoryType)
		{
			return null;
		}

		public bool GetInventoryItemByWorldObjectTypeInCategory(InventoryCategoryType pickups, WorldObjectType worldObjectType, out InventoryItem item)
		{
			item = null;
			return false;
		}

		public bool GetShopItemByWorldObjectTypeInCategory(InventoryCategoryType pickups, WorldObjectType woType, out ShopItem item)
		{
			item = null;
			return false;
		}

		public void UpdateItemData(int itemID, int itemCategoryID, byte[] data)
		{
		}
	}
}
