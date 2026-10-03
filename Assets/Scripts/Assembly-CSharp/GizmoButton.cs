using UnityEngine;
using UnityEngine.EventSystems;

public class GizmoButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[SerializeField]
	private GizmoAction gizmoAction;

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
