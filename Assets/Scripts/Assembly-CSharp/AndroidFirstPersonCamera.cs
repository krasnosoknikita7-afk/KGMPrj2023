using UnityEngine;

public class AndroidFirstPersonCamera : FirstPersonCamera
{
	[SerializeField]
	private AxisBias axisBias;

	[SerializeField]
	private InputMovementPrecisionModifier inputMovementPrecisionModifier;

	protected override void UpdateCameraRotation()
	{
	}

	private float DegreesBetween(float eulerA, float eulerB)
	{
		return 0f;
	}

	private float EulerClamp(float a, float min, float max)
	{
		return 0f;
	}
}
