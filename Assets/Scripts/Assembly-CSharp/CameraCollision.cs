using System.Collections.Generic;
using UnityEngine;

public class CameraCollision
{
	private const float verySmallDistance = 0.005f;

	public bool Collide(out Vector3 newPos, float cameraRadius, float baseDistance, Vector3 targetPosition, Vector3 cameraPosition, HashSet<int> ignoreIDs)
	{
		newPos = default;
		return false;
	}

	protected bool Collide(out VoxelHit hit, out Vector3 newPos, float cameraRadius, float baseDistance, Vector3 targetPosition, Vector3 cameraPosition, HashSet<int> ignoreIDs)
	{
		hit = default;
		newPos = default;
		return false;
	}
}
