using UnityEngine;

public class CameraShake : MonoBehaviour
{
	private float shakeStrength;

	private float shakeDuration;

	private Vector3 shakeOffset;

	[SerializeField]
	private float shakeMaxFactor;

	[SerializeField]
	private float shakeTimeFactor;

	[SerializeField]
	private float shakeStrengthFadeSpeed;

	[SerializeField]
	private AnimationCurve shakeFactorSpeedCurve;

	public Vector3 Shake(Vector3 position, float speed)
	{
		return default;
	}

	private Vector3 Shake(float speed)
	{
		return default;
	}
}
