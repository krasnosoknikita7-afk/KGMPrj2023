using UnityEngine;

public class FallBehindPitch
{
	private enum State
	{
		FallingBehind = 0,
		RotationSet = 1
	}

	private Vector3 prevCameraRotatedPosition;

	private Vector3 prevPosition;

	private const float distanceBeforeFallBehind = 2f;

	private const float degreesPrMeter = 3f;

	private State state;

	public Quaternion Update(Quaternion rotation, Vector3 position, float basePitch)
	{
		return default;
	}

	private Quaternion FallBehind(Quaternion rotation, Vector3 position, float basePitch)
	{
		return default;
	}

	private float DoFallBehind(float currentPitch, Vector3 position, float basePitch)
	{
		return 0f;
	}

	public void SetCameraRotatePos(Vector3 position)
	{
	}
}
