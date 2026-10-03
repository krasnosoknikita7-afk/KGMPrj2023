using UnityEngine;

public class TargetRotation : MonoBehaviour
{
	private Vector3 eulerAngles;

	[SerializeField]
	private float lerpSpeedX;

	[SerializeField]
	private float lerpSpeedY;

	public Vector3 EulerAngles => default;

	public void SetTargetRotation(Vector2 pitchYaw)
	{
	}

	public void SetTargetRotation(float pitch, float yaw)
	{
	}

	public void SetTargetRotation(Quaternion q)
	{
	}

	public Quaternion GetLerpRotation(Quaternion from)
	{
		return default;
	}
}
