using UnityEngine;

public class JoystickLockAxis
{
	private Vector2 prevPos;

	private SmoothTouchAxis smoothTouchAxis;

	private const float minDotForSupress = 0.8f;

	private const float movementRangeFactor = 0.9f;

	public void Reset(Vector2 startPos)
	{
	}

	public Joystick.SupressAxisFlag UpdateLockToAxis(Vector3 position, float normalizedDistance)
	{
		return Joystick.SupressAxisFlag.None;
	}

	private Joystick.SupressAxisFlag SetLockToAxis(Vector2 movement, float normalizedDistance)
	{
		return Joystick.SupressAxisFlag.None;
	}
}
