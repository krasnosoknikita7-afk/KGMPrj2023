using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlots : MonoBehaviour, IGameObjectDroppedInSlot, IEventSystemHandler
{
	private readonly Dictionary<int, InventorySlot> inventorySlots;

	[SerializeField]
	private InventorySlot inventorySlotPrefab;

	public int SlotCountPerPage { get; private set; }

	public void Initialize(int numberOfSlots)
	{
	}

	public Dictionary<int, InventorySlot> GetSlots()
	{
		return null;
	}

	public void HighlightSlot(int slotPosition)
	{
	}

	public void Clear()
	{
	}

	public void UpdateAbsoluteSlotValues(int page, int numberOfSlots)
	{
	}

	public void AddItem(GameObject item, int slotIndex)
	{
	}

	public void SlotChanged(GameObject draggedItem, int toSlotIndex)
	{
	}

	private InventorySlot GetSlotBasedOnAbsolute(int absoluteSlotIndex)
	{
		return null;
	}
}
