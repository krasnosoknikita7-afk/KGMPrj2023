using UnityEngine;

public class TransitionCamera : MVCameraBase
{
	private float fieldOfView;

	private float transitionPercentage;

	private bool superSoft;

	private Vector3 prevCameraPosition;

	private Quaternion prevCameraRotation;

	private float time;

	public override float FieldOfView => 0f;

	public float TransitionPercentage => 0f;

	public override CameraType CameraType => CameraType.ThirdPerson;

	public void InitTransition(Transform targetCameraTransform, float transitionTime = 2f, bool soft = false)
	{
	}

	public void AbortTransition()
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	private Quaternion RotateTowardsY(Vector3 eulerFrom, Vector3 eulerTo, float percentage)
	{
		return default;
	}

	private Quaternion RotateTowardsX(Vector3 eulerFrom, Vector3 eulerTo, float percentage)
	{
		return default;
	}
}
