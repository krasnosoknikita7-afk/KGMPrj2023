using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class ConsoleDragAndTapHandler : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
{
	public UnityAction OnClick;

	private bool dragging;

	private float dragStart;

	private const float minDragDurationForClick = 0.2f;

	private bool scrollingEnabled;

	[SerializeField]
	private ScrollRect scrollRect;

	public void OnChatModeClick()
	{
	}

	public void SetScrollingEnabled(bool scrollEnabled)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}
}
