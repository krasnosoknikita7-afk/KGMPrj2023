using System.Collections.Generic;
using UGUI.Desktop.Scripts.EditMode.Inventories;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInventoryController : MonoBehaviour, IPlayerInventory, IEventSystemHandler
{
	[SerializeField]
	private InventoryController inventoryControllerPrefab;

	[SerializeField]
	private int numberOfSlotsPrPage;

	[SerializeField]
	private PlayerInventoryPreviewItem previewItemPrefab;

	private Transform previewRootTransform;

	private Transform tempPreviewRoot;

	private InventoryController inventoryController;

	private int selectedTab;

	private readonly Dictionary<int, TabState> tabs;

	private readonly Dictionary<int, string> tabsNonLocalized;

	private readonly List<MVWorldObjectClient> previewedObjects;

	private PlayerShopInventoryRepository repository;

	private List<InventoryItem> items;

	private List<InventoryItem> itemsWithData;

	private PlayerInventoryPreviewItem draggedPreviewItem;

	private MVWorldObjectClient worldObjectDataCopy;

	private InventoryItemPreviewer draggedPreview;

	public void Initialize()
	{
	}

	private void InventoryChanged()
	{
	}

	private void UpdatePageCount()
	{
	}

	private static bool UsingDragAndDrop(InventoryCategoryType categoryType)
	{
		return false;
	}

	public void Activate(UIPushOption options)
	{
	}

	public void OpenTab(UIPushOption options, int categoryId)
	{
	}

	public void OpenPage(UIPushOption options, int categoryId, int slotPosition)
	{
	}

	public void ActivateAtCategoryWithSlot(UIPushOption options, int categoryId, int slotPosition)
	{
	}

	private void OnPop()
	{
	}

	private void TabSelected(int tab)
	{
	}

	private void PageTurned(int dir)
	{
	}

	private void PreserveDraggedItemAcrossPages()
	{
	}

	public void UpdateContent()
	{
	}

	private void UpdateSlotsWithDragAndDrop(TabState tabState)
	{
	}

	private void UpdateSlots(TabState tabState)
	{
	}

	private void SlotChanged(int from, int to)
	{
	}

	private static MVWorldObjectClient GetWorldObjectFromItemData(InventoryItem item)
	{
		return null;
	}

	public void SetCurrentDragTarget(GameObject draggingGameObject)
	{
	}

	public void DragFailed()
	{
	}

	public void ItemDataLoaded(PlayerInventoryPreviewItem itemPreview, InventoryItem inventoryItem)
	{
	}
}
