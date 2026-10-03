using System;
using UnityEngine;

public class InputToPlayerMovementAvatarEdit : IInputToPlayerMovement
{
	[Flags]
	private enum MovementMapFlags
	{
		None = 0,
		Left = 1,
		Forward = 2,
		Right = 4,
		Back = 8,
		Jump = 0x10
	}

	private MovementMapFlags frameUpdateMovementMapState;

	private MovementMapFlags movementMapState;

	public Vector3 Direction => default;

	public bool Jump => false;

	public void HandleInputState(bool fromFrameUpdate)
	{
	}
}
