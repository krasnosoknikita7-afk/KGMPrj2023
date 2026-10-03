using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler, IEventSystemHandler
{
	[SerializeField]
	private NotificationFade fade;

	public int AbsoluteSlot { get; private set; }

	public GameObject Item => null;

	public void Clear()
	{
	}

	public void UpdateAbsoluteSlotValue(int slotValue)
	{
	}

	public void HighlightSlot()
	{
	}

	public void Set(GameObject item)
	{
	}

	public void OnDrop(PointerEventData eventData)
	{
	}
}
