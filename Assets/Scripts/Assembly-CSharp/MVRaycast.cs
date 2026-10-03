using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public static class MVRaycast
{
	private const float HALF_VOXEL_SIZE = 0.5f;

	private const float LINE_FACET_TEST_DISTANCE = 300f;

	private static Bounds cubeBounds;

	private static Ray intersectRay;

	private static HashSet<int> foundWos;

	private static List<VoxelHit> voxelHits;

	private static List<RaycastHit> sortedHits;

	private static List<Collider> colliderList;

	public static bool MVHit(Ray ray, MVWorldObjectClient wo, out VoxelHit voxelHit, float distance = float.PositiveInfinity)
	{
		voxelHit = default;
		return false;
	}

	public static List<VoxelHit> MVHitAll(Ray ray, float distance = float.PositiveInfinity, int layerMask = -5, HashSet<int> ignoreWoIds = null)
	{
		return null;
	}

	public static bool MVHit(Ray ray, out VoxelHit voxelHit, float distance = float.PositiveInfinity, int layerMask = -5, HashSet<int> ignoreWoIds = null)
	{
		voxelHit = default;
		return false;
	}

	private static List<VoxelHit> MVHit(Ray ray, bool all, float distance, int layerMask, HashSet<int> ignoreWoIds)
	{
		return null;
	}

	private static bool HitDetectOnWo(Ray ray, int i, MVWorldObjectClient wo, PhysicsCollisionDatasWrapper collisionData, bool handleObjectsInsideBoxCollider, out VoxelHit voxelHit, HashSet<int> ignoreWoIds, float distance = float.PositiveInfinity)
	{
		voxelHit = default;
		return false;
	}

	private static void HandleObjectsInsideBoxCollider(Ray ray, int indexOfFirstHit, PhysicsCollisionDatasWrapper collisionData, ref VoxelHit voxelHit, HashSet<int> ignoreWoIds, float distance)
	{
	}

	private static void SetFoundHitVariables(ref VoxelHit voxelHit, PhysicsCollisionData collisionData, ICubeModelCollider cubeModelBase)
	{
	}

	private static bool IsWithinDistance(float distance, Vector3 localOrigin, IntVector voxelPos)
	{
		return false;
	}

	private static bool GetCellOnRay(Ray ray, ref VoxelHit vHit, GameObject chunk, ICubeModelCollider cmb, Vector3 hitPoint, float distance, Vector3 scale)
	{
		return false;
	}

	private static bool GetHitPoint(Ray ray, Cube cube, ref VoxelHit vHit, IntVector voxelPos, Vector3 localBoundsHitPoint, Vector3 scale, float scaledDistance)
	{
		return false;
	}
}
