using UnityEngine;

public class AvatarInputController : IAvatarInputController, IMotorAPI
{
	private Vector3 direction;

	private Quaternion rotation;

	private bool jump;

	private static Camera mainCamera;

	public Vector3 Direction
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Quaternion Rotation
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public bool Jump => false;

	public void HandleInput(Vector3 moveDirection, bool jump, bool didShoot, Vector3 velocity, bool inGunMode, bool forceRotateToCamDirection)
	{
	}

	private static Vector3 ToCameraDirection(Vector3 moveDirection)
	{
		return default;
	}

	private static Quaternion GetCameraYRotation()
	{
		return default;
	}

	private static Quaternion GetRotationMoveDirection(Vector3 moveDirection)
	{
		return default;
	}

	private static bool RotateToCameraDirection(bool didShoot, bool inGunOrForce, Vector3 velocity)
	{
		return false;
	}

	private static bool RotateToCameraDirectionBecauseOfShooting(Vector3 velocity)
	{
		return false;
	}

	private static bool RotateToCameraDirection(Vector3 velocity)
	{
		return false;
	}
}
