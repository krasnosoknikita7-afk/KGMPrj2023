using UnityEngine;

public class AvatarInputControllerAndroid : IAvatarInputController, IMotorAPI
{
	private Vector3 direction;

	private Quaternion rotation;

	private bool jump;

	private AvatarInputControllerAndroidSettings settings;

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

	public void HandleDead()
	{
	}

	public void HandleInput(Vector3 moveDirection, bool jump, bool didShoot, Vector3 velocity, bool inGunMode, bool forceRotateToCamDirection)
	{
	}

	private Vector3 GetDirectionBias(Vector3 absolutDirection)
	{
		return default;
	}

	private Vector3 GetBiasedDirection(Vector3 absoluteDirection, Vector3 testDirection)
	{
		return default;
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
}
