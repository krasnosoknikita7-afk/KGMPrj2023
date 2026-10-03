using UnityEngine;

public class VehicleCamera : PlaymodeCamera, IVehicleCamera
{
	private float rotationAroundY;

	private Transform originalTransformParent;

	[SerializeField]
	private Transform LookAtTransform;

	private const string mouseX = "Mouse X";

	private const string mouseY = "Mouse Y";

	public float RotationAroundY
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override CameraType CameraType => CameraType.ThirdPerson;

	public override void Initialize(MVAvatarLocal avatarLocal)
	{
	}

	public override void Reset()
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	public override void Enter(MVCameraController cameraController)
	{
	}

	public override void Exit(MVCameraController camController)
	{
	}

	private void UpdateTargetRotation()
	{
	}
}
