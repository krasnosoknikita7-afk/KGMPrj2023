using UnityEngine;

public abstract class MVCameraBase : MonoBehaviour
{
	private CameraImpact cameraImpact;

	protected IgnoreInputTypes ignoreInputTypes;

	public float cameraRadius;

	protected bool InputActive => false;

	public abstract CameraType CameraType { get; }

	public virtual float FieldOfView => 0f;

	public virtual void Awake()
	{
	}

	public void camController_onIgnoreInputTypes(object sender, OnIgnoreInputTypesArgs e)
	{
	}

	public virtual void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	protected void UpdateImpactSimulation(ProtectedTransform targetTransform)
	{
	}

	public void SimulateImpact(Vector3 impactDirection, AnimationCurve impactCurve, float forceMultiplier = 1f, Space impactSpace = Space.World)
	{
	}

	private void SimulateImpact(Transform targetTransform)
	{
	}

	private void SimulateImpact(Transform targetTransform, Vector3 impactDirection, AnimationCurve impactCurve, float forceMultiplier, Space impactSpace = Space.World)
	{
	}

	public virtual void Enter(MVCameraController camController)
	{
	}

	public virtual void Exit(MVCameraController camController)
	{
	}

	public virtual void Suspend(MVCameraController camController)
	{
	}

	public virtual void Resume(MVCameraController camController)
	{
	}

	public virtual void Reset()
	{
	}

	public virtual void FocusOnObject(MVWorldObjectClient wo, float transitionTime = 2f, Vector3 avatarOffset = default(Vector3), Vector3 cameraOffset = default(Vector3))
	{
	}

	public virtual void Activate()
	{
	}

	public virtual void Deactivate()
	{
	}
}
