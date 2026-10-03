using System.Collections.Generic;
using UnityEngine;

public class GhostCamera : MVCameraBase
{
	[SerializeField]
	private Vector3 offset;

	[SerializeField]
	private float height;

	[SerializeField]
	private float desiredDistance;

	private Vector3 avatarHeadOffset;

	private MVAvatarLocal avatarLocal;

	private HashSet<int> ignoreAvatarId;

	protected AvatarCameraDistTransparency avatarCameraDistTransparency;

	protected Transform lookAtTransform;

	private float distance;

	private Vector3 currentLookAt;

	protected Vector3 lookAtPos;

	private Vector3 actualLookAt;

	private Vector3 prevLookAtTransformPos;

	public override CameraType CameraType => CameraType.ThirdPerson;

	public void Initialize(MVAvatarLocal avatarLocal)
	{
	}

	public override void Enter(MVCameraController camController)
	{
	}

	public override void Exit(MVCameraController camController)
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

	private Vector3 GetLookAtPosition()
	{
		return default;
	}

	public override void Reset()
	{
	}
}
