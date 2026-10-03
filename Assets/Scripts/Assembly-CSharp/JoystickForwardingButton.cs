using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickForwardingButton : JoystickBase
{
	private Vector2 startPosition;

	private bool isDragging;

	[SerializeField]
	private JoystickBase joystickBase;

	[SerializeField]
	private float deadZoneBase;

	private float DeadZone => 0f;

	public override void OnDrag(PointerEventData eventData)
	{
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	private void OnDisable()
	{
	}
}
