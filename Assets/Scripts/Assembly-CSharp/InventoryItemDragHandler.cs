using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryItemDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
{
	[SerializeField]
	private CanvasGroup canvasGroup;

	private static bool dragging;

	public static bool dragRejected;

	public static bool Dragging => false;

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}
}
