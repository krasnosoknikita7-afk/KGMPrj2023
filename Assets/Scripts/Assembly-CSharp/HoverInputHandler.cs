using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverInputHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private List<HoverInputReceiver> hoverInputReceivers;

	public void SubscribeToHoverInput(HoverInputReceiver newInputReceiver)
	{
	}

	public void UnsubscribeToHoverInput(HoverInputReceiver newInputReceiver)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
