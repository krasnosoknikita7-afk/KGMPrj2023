using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragInputHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
{
	private List<IDragInputReciever> dragInputRecievers;

	public void AddInputReciever(IDragInputReciever newInputReciever)
	{
	}

	public void RemoveInputReciever(IDragInputReciever inputReciever)
	{
	}

	public void OnBeginDrag(PointerEventData data)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}
}
