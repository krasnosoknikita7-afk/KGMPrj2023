using System.Collections.Generic;
using UnityEngine;

public class LobbyStateCamera : MVCameraBase
{
	[SerializeField]
	private Vector3 offset;

	[SerializeField]
	private float height;

	private Vector3 avatarHeadOffset;

	private MVAvatarLocal avatarLocal;

	private HashSet<int> ignoreAvatarId;

	protected AvatarCameraDistTransparency avatarCameraDistTransparency;

	public override CameraType CameraType => CameraType.ThirdPerson;

	public void Initialize(MVAvatarLocal avatarLocal)
	{
	}

	public override void Enter(MVCameraController camController)
	{
	}

	public void SetRotation(Quaternion rotation)
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	private Vector3 PositionAfterCollision(Vector3 desiredPosition, Vector3 moveToPosition)
	{
		return default;
	}

	private Vector3 GetLookAtPosition()
	{
		return default;
	}

	public override void Exit(MVCameraController camController)
	{
	}

	public override void Reset()
	{
	}
}
