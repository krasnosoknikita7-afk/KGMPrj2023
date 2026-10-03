using UnityEngine;

public class AvatarEditModeCamera : JetPackCamera
{
	public override CameraType CameraType => CameraType.ThirdPerson;

	public void ResetPosition(Vector3 lookAtPosition)
	{
	}
}
