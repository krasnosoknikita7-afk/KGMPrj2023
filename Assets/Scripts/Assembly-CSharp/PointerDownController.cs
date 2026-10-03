using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PointerDownController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	private bool isInitialized;

	private UnityAction pointerDownCallback;

	public void Initialize(UnityAction pointerDownCallback)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
