using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class JumpTouchForwardingButton : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler, IDragHandler
{
	private const float deadZoneBase = 10f;

	private bool touchPadEnabled;

	private Vector2 startPos;

	private float prevScale;

	private bool initialized;

	[SerializeField]
	private TouchPadAbsolute touchPadAbsolute;

	[SerializeField]
	private bool horizontalEnabled;

	[SerializeField]
	private bool verticalEnabled;

	private float DeadZone => 0f;

	private void Start()
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}
}
