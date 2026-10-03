using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour, IPagedTurned, IEventSystemHandler, ITabSelected, ISlotChanged
{
	private int numberOfSlots;

	[SerializeField]
	private TabMenuBase tabMenu;

	[SerializeField]
	private InventorySlots inventorySlots;

	[SerializeField]
	private Text categoryHeaderText;

	public UnityAction<int> OnPageTurned;

	public UnityAction<int> OnTabSelected;

	public UnityAction<int, int> OnSlotChanged;

	public void Initialize(int slots)
	{
	}

	public void Clear()
	{
	}

	public void SetHeaderText(string category)
	{
	}

	public void HighlightSlot(int slotPosition)
	{
	}

	public void AddTab(int categoryId, string tabName)
	{
	}

	public void SelectTab(int tabId, int currentPage, int maxPages)
	{
	}

	public void AddObject(GameObject item, int slotIndex)
	{
	}

	public void PageTurned(int dir)
	{
	}

	public void TabSelected(int tabId)
	{
	}

	public void SlotChanged(int fromSlotIndex, int toSlotIndex)
	{
	}

	public List<T> GetComponentsOfSlotsWithType<T>() where T : MonoBehaviour
	{
		return null;
	}
}
