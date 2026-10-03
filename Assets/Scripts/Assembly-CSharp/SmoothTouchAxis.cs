using System.Collections.Generic;
using UnityEngine;

public class SmoothTouchAxis
{
	private readonly int sampleLength;

	private readonly Queue<Vector3> prevVelocities;

	public SmoothTouchAxis(int sampleLength)
	{
	}

	public void Reset()
	{
	}

	public Vector3 UpdateSmoothVelocity(Vector3 movement)
	{
		return default;
	}
}
