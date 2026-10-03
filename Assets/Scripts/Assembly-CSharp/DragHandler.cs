using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
{
	private Vector3 startPos;

	private static bool dragging;

	[SerializeField]
	private CanvasGroup canvasGroup;

	public static bool Dragging => false;

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}
}
