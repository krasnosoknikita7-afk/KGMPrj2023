using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerInventoryItemManager : MonoBehaviour, ITabSelected, IEventSystemHandler
{
	private class ItemManagePageDef
	{
		public readonly TabMenuButton Button;

		public readonly ManageItemPage PageItemPrefab;

		public ItemManagePageDef(TabMenuButton button, ManageItemPage pageItemPrefab)
		{
		}
	}

	[SerializeField]
	private TabMenuButton tabMenuButtonPrefab;

	[SerializeField]
	private RectTransform tabsRoot;

	[SerializeField]
	private RectTransform pageContentRoot;

	[SerializeField]
	private ItemInfoTab infoTabPrefab;

	[SerializeField]
	private InventoryItemPreviewSell itemSellTabPrefab;

	[SerializeField]
	private ItemInventoryDeleteTab ItemRemovalPrefab;

	private readonly List<ItemManagePageDef> tabList;

	private int currentTab;

	private InventoryItem previewedItem;

	private ManageItemPage currentManageItemPage;

	private RawImage itemImage;

	public void Initialize(InventoryItem item, RawImage itemPreview)
	{
	}

	private void AddTabMenuButton(int categoryIndex, string categoryName, ManageItemPage pageItem)
	{
	}

	public void TabSelected(int tabId)
	{
	}

	public void UpdateContent()
	{
	}
}
