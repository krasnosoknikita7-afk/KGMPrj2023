using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : JoystickBase
{
	private float alphaOn;

	[SerializeField]
	private JoystickBase joystick;

	[SerializeField]
	private RectTransform rectTransform;

	[SerializeField]
	private RectTransform startPosVisulization;

	[SerializeField]
	private CanvasGroup canvasGroup;

	private void Start()
	{
	}

	private void ScalePhysicalSize()
	{
	}

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
