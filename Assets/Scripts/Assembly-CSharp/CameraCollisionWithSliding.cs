using System.Collections.Generic;
using UnityEngine;

public class CameraCollisionWithSliding : CameraCollision
{
	private float slideDir;

	private int prevFrameCount;

	private float checkDistanceFactor;

	public bool CollideWithSliding(out Vector3 newCameraPosition, float cameraRadius, float distanceToAvatar, Vector3 targetPosition, Vector3 cameraPosition, HashSet<int> ignoreAvatarId)
	{
		newCameraPosition = default;
		return false;
	}

	private void ResetIfNotUpdate()
	{
	}

	private bool DoCollideWithSliding(out Vector3 newPos, float cameraRadius, float baseDistance, Vector3 targetPosition, Vector3 cameraPosition, HashSet<int> ignoreIDs)
	{
		newPos = default;
		return false;
	}

	private void Reset()
	{
	}

	private Vector3 GetSlideVector(Vector3 newPos, Vector3 hitPoint, Vector3 targetPosition, Vector3 cameraPosition, float baseDistance)
	{
		return default;
	}

	private Vector3 GetSlideVectorXZPlane(Vector3 newPos, Vector3 hitPoint, Vector3 targetPosition, Vector3 cameraPosition, float baseDistance)
	{
		return default;
	}

	private Vector3 GetSlideDir(Vector3 newPos, Vector3 hitPoint, Vector3 targetPosition, Vector3 cameraPosition)
	{
		return default;
	}

	private static float GetSlideVectorLength(Vector3 slideVector, Vector3 newPos, Vector3 targetPosition, float baseDistance)
	{
		return 0f;
	}
}
