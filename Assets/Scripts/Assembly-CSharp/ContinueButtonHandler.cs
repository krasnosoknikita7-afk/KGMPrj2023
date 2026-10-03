using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class ContinueButtonHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	public Action OnClick;

	private bool isMoveOverButton;

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
