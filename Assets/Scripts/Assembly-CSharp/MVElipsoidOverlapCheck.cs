using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public static class MVElipsoidOverlapCheck
{
	private static Matrix4x4 worldToElipsoidSpace;

	private static Matrix4x4 elipsoidSpaceToWorld;

	private static Matrix4x4 localToElipsoidSpace;

	private static Vector3 localElipsoidPosition;

	private static Matrix4x4 worldToRadiusExtendedElipsoidSpace;

	private static Matrix4x4 radiusExtendedElipsoidSpaceToWorld;

	private static Matrix4x4 localToRadiusExtendedElipsoidSpace;

	private static bool reducedElipsoidSpaceExists;

	private static Matrix4x4 worldToRadiusReducedElipsoidSpace;

	private static Matrix4x4 radiusReducedElipsoidSpaceToWorld;

	private static Matrix4x4 localToRadiusReducedElipsoidSpace;

	private static Matrix4x4 localToWorld;

	private static Matrix4x4 worldToLocal;

	private static Vector3[] cachedCorners;

	private static Vector3[] cachedFace;

	private const float SQRT_3 = 1.7320508f;

	private static ElipsoidOverlapCheckType checkType;

	private static List<IntVector> cachedIntVectors;

	public static bool ElipsoidOverlapCheckBool(Vector3 radius, Vector3 position, Quaternion rotation, int layerMask = -5, HashSet<int> ignoreWoIds = null)
	{
		return false;
	}

	public static List<MVOverlapResult> ElipsoidOverlapCheckSector(Vector3 radius, Vector3 position, Quaternion rotation, int layerMask = -5, HashSet<int> ignoreWoIds = null)
	{
		return null;
	}

	public static bool ElipsoidOverlapCheckBool(Vector3 position, Transform transform, Bounds localBounds, int layerMask = -5, HashSet<int> ignoreWoIds = null)
	{
		return false;
	}

	public static List<MVOverlapResult> ElipsoidOverlapCheckSector(Vector3 position, Transform transform, Bounds localBounds, int layerMask = -5, HashSet<int> ignoreWoIds = null)
	{
		return null;
	}

	private static List<MVOverlapResult> ElipsoidOverlapCheck(Vector3 position, Transform transform, Bounds localBounds, HashSet<int> ignoreWoIds, int layerMask = -5)
	{
		return null;
	}

	private static List<MVOverlapResult> ElipsoidOverlapCheck(Vector3 radius, Vector3 position, Quaternion rotation, HashSet<int> ignoreWoIds, int layerMask = -5)
	{
		return null;
	}

	private static bool ElipsoidOverlapCheckOnWo(Vector3 radius, Vector3 position, Quaternion rotation, BoxCollider chunk, MVWorldObjectClient wo, out MVOverlapResult elipsoidOverlapResult)
	{
		elipsoidOverlapResult = default;
		return false;
	}

	private static bool ScanElipsoidBounds(Bounds localElipsoidBounds, BoxCollider chunk, ICubeModelCollider cmb, ref MVOverlapResult elipsoidOverlapResult)
	{
		return false;
	}

	private static bool HandleCube(IntVector cubePos, ICubeModelCollider cmb, ref MVOverlapResult elipsoidOverlapResult)
	{
		return false;
	}

	private static bool IsCenterPointWithinCube(Cube cube, Vector3 localPos)
	{
		return false;
	}

	private static bool DoDetailedCheck(Cube cube, Vector3 localPos)
	{
		return false;
	}

	private static bool HandleTriangleTest(Vector3 A, Vector3 B, Vector3 C, Vector3 P, float r)
	{
		return false;
	}

	private static Vector3[] GetTangentNormalsLocalSpace()
	{
		return null;
	}

	private static Bounds GetBoundsFromAxisAlignedVectors(Vector3[] vectors)
	{
		return default;
	}

	private static Bounds GetBoundsFromVectors(Vector3[] vectors)
	{
		return default;
	}

	private static Vector3 GetTangentNormal(Vector3 tangent0, Vector3 tangent1)
	{
		return default;
	}
}
