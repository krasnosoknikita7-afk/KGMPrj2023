using UnityEngine;

public class InputToPlayerMovementAndroid : IInputToPlayerMovement
{
	private bool jump;

	private bool jumpFrameUpdate;

	private bool jumpFixedUpdate;

	private Vector3 direction;

	public Vector3 Direction => default;

	public bool Jump => false;

	public void HandleInputState(bool fromFrameUpdate)
	{
	}
}
