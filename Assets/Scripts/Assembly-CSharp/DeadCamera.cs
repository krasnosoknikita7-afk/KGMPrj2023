using UnityEngine;

public class DeadCamera : MVCameraBase
{
	[SerializeField]
	private Vector3 avatarLocalLookAtOffset;

	private MVAvatarLocal avatarLocal;

	private Vector3 lookAtPos;

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

	private void UpdateRotation()
	{
	}
}
