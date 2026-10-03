using System.Collections.Generic;
using UnityEngine;

public class InventoryItem
{
	public class ItemDescription
	{
		private string name;

		private string explanation;

		private string inspirational;

		private Vector3 cameraPreviewerOffset;

		public Vector3 CameraPreviewerOffset => default;

		public string Name => null;

		public string Description => null;

		public ItemDescription(string name, string explanation, string inspirational)
		{
		}

		public ItemDescription(string name, string explanation, string inspirational, Vector3 cameraPreviewerOffset)
		{
		}
	}

	public readonly int itemID;

	public readonly int itemCategoryID;

	public readonly int itemTypeID;

	public string name;

	public string description;

	public byte[] data;

	public bool hasData;

	public readonly bool resellable;

	public readonly int priceGold;

	public bool purchased;

	public readonly int authorProfileID;

	public readonly int originalItemID;

	public readonly bool isDeleted;

	public readonly bool isDefaultInvItem;

	public int shopInventoryID;

	public int slotPosition;

	public string imagePath;

	public static readonly Dictionary<MVWorldObjectDocumentationType, ItemDescription> localItemDescriptionOverride;

	public InventoryItem()
	{
	}

	public InventoryItem(Dictionary<byte, object> data)
	{
	}

	public InventoryItem(int itemID, Dictionary<object, object> itemData)
	{
	}

	public InventoryItem(ShopItem itemToCopy)
	{
	}

	public void ApplyLocalDescriptionOverride(MVWorldObjectDocumentationType t)
	{
	}
}
