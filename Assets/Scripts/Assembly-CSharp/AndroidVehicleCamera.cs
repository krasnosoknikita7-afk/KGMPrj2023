using System.Collections.Generic;
using UnityEngine;

public class AndroidVehicleCamera : MVCameraBase, IVehicleCamera
{
	private MVAvatarLocal avatarLocal;

	private Transform originalTransformParent;

	private readonly CameraLerpToDesiredDistance cameraLerpToDesiredDistance;

	private readonly CameraCollision cameraCollision;

	private HashSet<int> ignoreAvatarId;

	[SerializeField]
	private TargetRotation targetRotation;

	[SerializeField]
	private Transform lookAtTransform;

	[SerializeField]
	private float mouseSensitivity;

	[SerializeField]
	private CameraShake cameraShake;

	[SerializeField]
	private float distanceToLookAt;

	[SerializeField]
	private float minimumY;

	[SerializeField]
	private float maximumY;

	[SerializeField]
	private float initialYRotation;

	[SerializeField]
	private float localPitch;

	[SerializeField]
	private Vector3 lookAtOffset;

	private float rotationX;

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

	public void Initialize(MVAvatarLocal avatarLocal)
	{
	}

	public override void Enter(MVCameraController camController)
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	public override void Exit(MVCameraController camController)
	{
	}

	private void HandleCollision()
	{
	}

	private void HandlePos()
	{
	}

	private void UpdateTargetRotation()
	{
	}
}
