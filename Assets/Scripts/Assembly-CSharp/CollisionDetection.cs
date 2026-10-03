using System.Collections.Generic;
using UnityEngine;

public static class CollisionDetection
{
	private const bool IGNORE_ALL = false;

	public static bool MVSphereCast(Ray ray, float radius, out VoxelHit voxelHit, float distance = float.PositiveInfinity, HashSet<int> ignoreWoIds = null, int layerMask = -5)
	{
		voxelHit = default;
		return false;
	}

	public static List<VoxelHit> MVSphereCastAll(Ray ray, float radius, float distance = float.PositiveInfinity, HashSet<int> ignoreWoIds = null, int layerMask = -5)
	{
		return null;
	}

	public static bool MVHit(Ray ray, MVWorldObjectClient wo, out VoxelHit voxelHit, float distance = float.PositiveInfinity)
	{
		voxelHit = default;
		return false;
	}

	public static List<VoxelHit> MVHitAll(Ray ray, float distance = float.PositiveInfinity, HashSet<int> ignoreWoIds = null, int layerMask = -5)
	{
		return null;
	}

	public static bool MVHit(Ray ray, out VoxelHit voxelHit, float distance = float.PositiveInfinity, HashSet<int> ignoreWoIds = null, int layerMask = -5)
	{
		voxelHit = default;
		return false;
	}

	public static List<VoxelHit> MVElipsoidCastAll(Ray ray, Vector3 radius, float distance, HashSet<int> ignoreWoIds = null, int layerMask = -5)
	{
		return null;
	}

	public static bool MVElipsoidCast(Ray ray, Vector3 radius, float distance, out VoxelHit voxelHit, HashSet<int> ignoreWoIds = null, int layerMask = -5)
	{
		voxelHit = default;
		return false;
	}

	public static List<VoxelHit> MVElipsoidCastAll(Ray ray, Transform transform, Bounds localBounds, float distance, HashSet<int> ignoreWoIds = null, int layerMask = -5)
	{
		return null;
	}

	public static bool MVElipsoidCast(Ray ray, Transform transform, Bounds localBounds, float distance, out VoxelHit voxelHit, HashSet<int> ignoreWoIds = null, int layerMask = -5)
	{
		voxelHit = default;
		return false;
	}

	public static List<MVOverlapResult> ElipsoidOverlapSector(Vector3 position, Quaternion rotation, Vector3 radius, HashSet<int> ignoreWoIds = null, int layerMask = -5)
	{
		return null;
	}
}
