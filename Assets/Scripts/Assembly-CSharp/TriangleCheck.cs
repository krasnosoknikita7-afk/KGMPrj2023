using UnityEngine;

public static class TriangleCheck
{
	private static bool GetLowestRoot(float a, float b, float c, float maxR, ref float root)
	{
		return false;
	}

	private static bool SameSide(ref Vector3 p1, ref Vector3 p2, ref Vector3 a, ref Vector3 b)
	{
		return false;
	}

	private static bool PointInTriangle(ref Vector3 p, ref Vector3 a, ref Vector3 b, ref Vector3 c)
	{
		return false;
	}

	private static bool IsFrontFacingTo(ref Plane plane, ref Vector3 direction)
	{
		return false;
	}

	private static bool IsFrontFacingTo(ref Vector3 planeNormal, ref Vector3 direction)
	{
		return false;
	}

	public static bool CheckTriangle(ref Vector3 p1, ref Vector3 p2, ref Vector3 p3, ref Vector3 localOrigin, ref Vector3 localDirection, float distance, ref VoxelHit voxelHit)
	{
		return false;
	}
}
