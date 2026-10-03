using System.Collections.Generic;

public class ThirdPersonCamera : PlaymodeCamera, ICameraSettings
{
	private float baseDistanceSettings;

	private const string mouseX = "Mouse X";

	private const string mouseY = "Mouse Y";

	public override CameraType CameraType => CameraType.ThirdPerson;

	public override void Activate()
	{
	}

	public override void Deactivate()
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	public void UpdateFromCameraSettings(Dictionary<object, object> data)
	{
	}

	public void SetDefaultSettings()
	{
	}

	public void ScaleCameraValues(float scale)
	{
	}

	private void ResetScaleValues()
	{
	}

	private void UpdateTargetRotation()
	{
	}
}
