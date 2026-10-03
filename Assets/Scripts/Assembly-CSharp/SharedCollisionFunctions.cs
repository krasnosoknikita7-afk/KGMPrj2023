using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public static class SharedCollisionFunctions
{
	private static readonly RaycastHitComparer rayHitComparer;

	private static readonly PhysicsCollisionDatasWrapper physicsCollisionWrapper;

	public static PhysicsCollisionDatasWrapper GetPhysicsCollisionData(Collider[] overlapResult, RaycastHit[] hits, Vector3 origin)
	{
		return null;
	}

	public static PhysicsCollisionDatasWrapper GetPhysicsCollisionData(int overlapAmount, Collider[] overlapResult, int hitAmount, RaycastHit[] hits, Vector3 origin)
	{
		return null;
	}

	public static void GetVoxelBounds(ref IntVector min, ref IntVector max, Bounds localSpaceBounds)
	{
	}

	public static void SetToNoneVoxelHit(ref VoxelHit voxelHit, PhysicsCollisionData hit, int woId)
	{
	}

	public static void SetToVoxelHit(ref VoxelHit voxelHit0, ref VoxelHit voxelHit1)
	{
	}

	public static bool IgnoreCollision(MVWorldObjectClient wo, HashSet<int> ignoreWoIds)
	{
		return false;
	}
}
