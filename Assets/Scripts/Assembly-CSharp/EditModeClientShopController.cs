using System.Collections.Generic;
using UGUI.Desktop.Scripts.EditMode.Inventories;
using UnityEngine;
using UnityEngine.EventSystems;

public class EditModeClientShopController : MonoBehaviour, IPurchaseClientShopItem, IEventSystemHandler, IOpenClientShop, IHighLightClientShopItem, IOpenClientShopTab, IOpenClientShopPage
{
	[SerializeField]
	private InventoryController inventoryControllerPrefab;

	[SerializeField]
	private int numberOfSlotsPrPage;

	[SerializeField]
	private EditModeClientShopItem previewItemPrefab;

	private Transform previewRootTransform;

	private InventoryController inventoryController;

	private int selectedTab;

	private readonly Dictionary<int, TabState> tabs;

	private readonly Dictionary<int, string> tabsNonLocalized;

	private readonly List<MVWorldObjectClient> previewedObjects;

	private PlayerShopInventoryRepository playerShopInventoryRepository;

	private EditModeRepositoryController repositoryController;

	public void Initialize(EditModeRepositoryController repositoryController)
	{
	}

	public void Activate(UIPushOption pushOption)
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

	private void UpdateContent()
	{
	}

	private static MVWorldObjectClient GetWorldObjectFromItemData(ShopItem item)
	{
		return null;
	}

	public void PurchaseItem(ShopItem item)
	{
	}

	public void HighlightAtCategoryWithSlot(UIPushOption options, int categoryId, int slotPosition)
	{
	}

	public void OpenTab(UIPushOption options, int categoryId)
	{
	}

	public void OpenPage(UIPushOption options, int categoryId, int slotPosition)
	{
	}
}
