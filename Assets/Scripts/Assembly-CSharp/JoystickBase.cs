using UnityEngine;
using UnityEngine.EventSystems;

public abstract class JoystickBase : MonoBehaviour, IJoystick, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	public abstract void OnDrag(PointerEventData eventData);

	public abstract void OnPointerDown(PointerEventData eventData);

	public abstract void OnPointerUp(PointerEventData eventData);
}
