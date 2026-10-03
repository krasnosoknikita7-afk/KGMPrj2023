using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class JoystickVehicleThirdPerson : JoystickBase
{
	private Vector3 startPos;

	private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

	private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

	[SerializeField]
	private int baseMovementRangeX;

	[SerializeField]
	private int baseMovementRangeY;

	[SerializeField]
	private string horizontalAxisName;

	[SerializeField]
	private string verticalAxisName;

	[SerializeField]
	private AnimationCurve deltaMovementModifierX;

	[SerializeField]
	private AnimationCurve deltaMovementModifierY;

	private float desiredDeltaX;

	private float currentDeltaX;

	private float MovementRangeX => 0f;

	private float MovementRangeY => 0f;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void OnDrag(PointerEventData data)
	{
	}

	public override void OnPointerUp(PointerEventData data)
	{
	}

	public override void OnPointerDown(PointerEventData data)
	{
	}

	private void CreateVirtualAxes()
	{
	}

	private void RegisterAxes()
	{
	}

	private void UpdateVirtualAxes(Vector3 value)
	{
	}

	private void Reset()
	{
	}
}
