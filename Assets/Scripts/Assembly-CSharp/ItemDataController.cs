using System.Collections.Generic;
using UnityEngine;

public class ItemDataController : MonoBehaviour
{
	private readonly int defaultCategoryID;

	private int currentTab;

	private List<InventoryItemData> inventoryItemDatas;

	private Dictionary<int, TabState> categories;

	[SerializeField]
	private InventoryController inventoryController;

	[SerializeField]
	private PreviewObject previewObject;

	[SerializeField]
	private TestItem testItemPrefab;

	[SerializeField]
	private int numberOfSlots;

	private void Start()
	{
	}

	public void SlotChanged(int fromSlotIndex, int toSlotIndex)
	{
	}

	private void PageTurned(int dir)
	{
	}

	private void TabSelected(int tabId)
	{
	}

	private void UpdateContent()
	{
	}

	private void InitializeTestData()
	{
	}

	private InventoryItemData GetItemData(int slot)
	{
		return null;
	}
}
