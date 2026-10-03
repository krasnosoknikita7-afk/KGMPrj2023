using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class Joystick : JoystickBase
{
	[Flags]
	public enum SupressAxisFlag
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2
	}

	private bool dragStart;

	private SupressAxisFlag supressAxis;

	private UIElipsoidHelper elipsoidHelper;

	private Vector3 startPos;

	private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

	private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

	[SerializeField]
	private int baseMovementRangeX;

	[SerializeField]
	private int baseMovementRangeY;

	private JoystickLockAxis joystickLockAxis;

	[SerializeField]
	private string horizontalAxisName;

	[SerializeField]
	private string verticalAxisName;

	[SerializeField]
	private AnimationCurve deltaMovementModifier;

	[SerializeField]
	private bool useSupressAxis;

	private float MovementRangeX => 0f;

	private float MovementRangeY => 0f;

	private void Awake()
	{
	}

	private void Update()
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
