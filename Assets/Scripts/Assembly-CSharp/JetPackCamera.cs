using UnityEngine;

public class JetPackCamera : MVCameraBase
{
	public float sensitivityX;

	public float sensitivityY;

	public float aroundXInertia;

	public float aroundYInertiaMouseControlled;

	public float aroundYInertiaAvatarControlled;

	public float minimumY;

	public float maximumY;

	public float scrollSpeed;

	public int xMinLimit;

	public int xMaxLimit;

	private Transform lookAtTransform;

	protected Vector3 lookAtOffset;

	protected float xAxisTarget;

	protected float yAxisTarget;

	protected float xAxis;

	protected float yAxis;

	protected float yAxisVelocity;

	protected float xAxisVelocity;

	private float rotationSmoothTime;

	private Camera mainCamera;

	private const float rotationSmoothTimeMouseControlled = 0.1f;

	protected MVBuildModeAvatarLocal avatarLocal;

	private const string mouseX = "Mouse X";

	private const string mouseY = "Mouse Y";

	public override CameraType CameraType => CameraType.ThirdPerson;

	public virtual void Initialize(MVBuildModeAvatarLocal avatarLocal)
	{
	}

	public override void Enter(MVCameraController camController)
	{
	}

	public override void Reset()
	{
	}

	private void ResetRotationToTargetTransform()
	{
	}

	public void HandleInput(MVCameraController cameraController)
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	protected static float NormalizeAngle(float angle)
	{
		return 0f;
	}

	public override void FocusOnObject(MVWorldObjectClient wo, float transitionTime = 2f, Vector3 avatarOffset = default(Vector3), Vector3 cameraOffset = default(Vector3))
	{
	}

	public void FocusOnPointFromAvatarPosition(Vector3 focusPoint, Vector3 avatarPosition)
	{
	}

	public void ResetDistanceAndDirectionToAvatar(Vector3 lookAtPosition)
	{
	}

	public void FocusOnPosition(Vector3 lookAtPosition, float transitionTime = 2f)
	{
	}

	private void SetToPosition(Vector3 position)
	{
	}

	private Vector3 GetLookAtAvatarPosition(Vector3 position)
	{
		return default;
	}

	private void LookAt(Vector3 position)
	{
	}
}
