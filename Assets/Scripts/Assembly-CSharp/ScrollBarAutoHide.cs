using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollBarAutoHide : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	[SerializeField]
	private NotificationFade scrollBarFader;

	[SerializeField]
	private CanvasGroup scrollbarCanvasGroup;

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}
}
