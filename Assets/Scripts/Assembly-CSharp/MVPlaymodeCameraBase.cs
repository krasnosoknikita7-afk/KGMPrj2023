using UnityEngine;

public abstract class MVPlaymodeCameraBase : MVCameraBase
{
	private float shakeStrength;

	private float shakeDuration;

	protected Vector3 shakeOffset;

	public float shakeMaxFactor;

	public float shakeTimeFactor;

	public float shakeStrengthFadeSpeed;

	public AnimationCurve shakeFactorSpeedCurve;

	public override void Exit(MVCameraController camController)
	{
	}

	protected void Shake(float speed)
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}
}
