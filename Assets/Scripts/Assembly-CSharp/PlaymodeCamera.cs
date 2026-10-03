using System.Collections.Generic;
using UnityEngine;

public abstract class PlaymodeCamera : MVPlaymodeCameraBase
{
	private class SmoothLookAt
	{
		private int samleLength;

		private Queue<Vector3> prevVelocities;

		private float maxMag;

		public Vector3 GetCurrentLookAt(Vector3 velocity)
		{
			return default;
		}

		public void Clear()
		{
		}
	}

	protected float distanceToAvatar;

	public float height;

	public float minimumY;

	public float maximumY;

	public Vector3 shoulderOffset;

	private Vector3 avatarHeadOffset;

	protected AvatarCameraDistTransparency avatarCameraDistTransparency;

	public float targetDistanceStrength;

	public float followRotationSpeed;

	public Vector3 lookAtOffset;

	protected Vector3 currentLookAtOffset;

	protected bool autoRotate;

	protected Vector3 currentLookAt;

	protected Vector3 actualLookAt;

	protected float distance;

	protected HashSet<int> ignoreAvatarId;

	protected Transform lookAtTransform;

	[SerializeField]
	protected TargetRotation targetRot;

	protected Vector3 lookAtPos;

	public float mouseSensitivity;

	protected float aroundYInertia;

	protected float lookAtScaleCorrection;

	protected MVAvatarLocal avatarLocal;

	private SmoothLookAt smoothLookAt;

	private Vector3 prevLookAtTransformPos;

	public override void Awake()
	{
	}

	public virtual void Initialize(MVAvatarLocal avatarLocal)
	{
	}

	public override void Enter(MVCameraController cameraController)
	{
	}

	public override void Reset()
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	private void UpdatePosition()
	{
	}

	protected virtual void CameraCollision()
	{
	}
}
