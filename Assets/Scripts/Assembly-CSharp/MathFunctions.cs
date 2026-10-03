using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public static class MathFunctions
{
	public enum IntersectResult
	{
		PARALLEL = 0,
		COINCIDENT = 1,
		NOT_INTERESECTING = 2,
		INTERESECTING = 3
	}

	public static class PerlinSimplexNoise
	{
		private static int[][] grad3;

		private static int[] p;

		private static readonly int[] perm;

		static PerlinSimplexNoise()
		{
		}

		private static int fastfloor(float x)
		{
			return 0;
		}

		private static float dot(int[] g, float x, float y)
		{
			return 0f;
		}

		private static float dot(int[] g, float x, float y, float z)
		{
			return 0f;
		}

		private static float dot(int[] g, float x, float y, float z, float w)
		{
			return 0f;
		}

		public static float noise(float xin, float yin, float zin)
		{
			return 0f;
		}

		public static float noise(float xin, float yin)
		{
			return 0f;
		}
	}

	public static float DotProduct(ref Vector3 a, ref Vector3 b)
	{
		return 0f;
	}

	public static Vector3 Multiply(this Vector3 a, Vector3 b)
	{
		return default;
	}

	public static Vector3 GetMinVector(Vector3 min0, Vector3 min1)
	{
		return default;
	}

	public static Vector3 GetMaxVector(Vector3 max0, Vector3 max1)
	{
		return default;
	}

	public static double SignedDistanceTo(ref Plane plane, ref Vector3 planeOrigin, ref Vector3 point)
	{
		return 0.0;
	}

	public static double SignedDistanceTo(ref Vector3 planeNormal, ref Vector3 planeOrigin, ref Vector3 point)
	{
		return 0.0;
	}

	public static void ClampIntVector(ref IntVector target, IntVector min, IntVector max)
	{
	}

	public static Vector3 MultiplyVector(ref Vector3 vec0, ref Vector3 vec1)
	{
		return default;
	}

	public static Vector3 DivideVector(ref Vector3 vec0, ref Vector3 vec1)
	{
		return default;
	}

	public static Vector3 AbsVector(Vector3 vec)
	{
		return default;
	}

	public static Vector2 xy(this Vector3 v)
	{
		return default;
	}

	public static Vector3 RoundVector(Vector3 vector, int decimals)
	{
		return default;
	}

	public static Vector3 FloorVector(Vector3 vector)
	{
		return default;
	}

	public static Vector3 CeilVector(Vector3 vector)
	{
		return default;
	}

	public static bool VectorIsNan(Vector3 vector)
	{
		return false;
	}

	public static bool QuaternionIsNan(Quaternion quaternion)
	{
		return false;
	}

	public static bool VectorIsFinite(Vector3 vector)
	{
		return false;
	}

	public static bool QuaternionIsFinite(Quaternion quaternion)
	{
		return false;
	}

	public static bool IsQuaternionFloatsValid(Quaternion quaternion)
	{
		return false;
	}

	public static bool IsVectorFloatsValid(Vector3 vector)
	{
		return false;
	}

	public static bool IsFloatValid(float floatToValidate)
	{
		return false;
	}

	public static Vector3 TruncateVector(Vector3 vector, int digits)
	{
		return default;
	}

	public static double Truncate(double number, int digits)
	{
		return 0.0;
	}

	public static IntVector ToIntVector(this Vector3 v)
	{
		return default;
	}

	public static void Vector3ToVector2(ref Vector3 from, ref Vector2 to, int ignoreAxis)
	{
	}

	public static void Vector2ToVector3(ref Vector2 from, ref Vector3 to, int addAxis, float addValue = 0f)
	{
	}

	public static bool DoLinesIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 ptIntersection)
	{
		return false;
	}

	public static bool IsCoincidentalLineSegmentsOverlapping(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
	{
		return false;
	}

	public static IntersectResult Intersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 ptIntersection)
	{
		return IntersectResult.PARALLEL;
	}

	public static bool IsPointInShape(IList<Vector2> shapePoints, Vector2 point)
	{
		return false;
	}

	public static int IsLineSegmentIntersectingShape(Vector2 p0, Vector2 p1, List<Vector2> points, bool isOpen)
	{
		return 0;
	}

	public static float SignedAngle(Vector2 v1, Vector2 v2)
	{
		return 0f;
	}

	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 normal)
	{
		return 0f;
	}

	public static float Yaw(Vector3 dir)
	{
		return 0f;
	}

	public static float Pitch(Vector3 dir, Vector3 planeNormal)
	{
		return 0f;
	}

	public static float SignedYawFromLocalDirection(Vector3 localDirection)
	{
		return 0f;
	}

	public static float PitchFromLocalDirection(Vector3 localDirection)
	{
		return 0f;
	}

	public static Quaternion QuaternionFromAngleAndAxis(float angle, Vector3 AxisVector)
	{
		return default;
	}

	public static List<Vector2> FlipPolygon(List<Vector2> points)
	{
		return null;
	}

	public static void ClampVector(ref Vector3 v, float min, float max)
	{
	}

	public static void ClampVector(ref Vector3 v, Vector3 min, Vector3 max)
	{
	}

	public static bool DistancePointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd, ref float distance)
	{
		return false;
	}

	public static bool DistancePointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd, ref float distance, ref Vector3 intersection)
	{
		return false;
	}

	public static void DistancePointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd, out float distance, out Vector3 intersection, out float u)
	{
		distance = default;
		intersection = default;
		u = default;
	}

	public static Vector3 GetNormal(Vector3 pa, Vector3 pb, Vector3 pc)
	{
		return default;
	}

	public static bool LineFacetCollision(Vector3 p1, Vector3 p2, Vector3 pa, Vector3 pb, Vector3 pc, Vector3 lineDir, ref Vector3 p, ref Vector3 n)
	{
		return false;
	}

	public static bool LineFacet(Vector3 p1, Vector3 p2, Vector3 pa, Vector3 pb, Vector3 pc, ref Vector3 p)
	{
		return false;
	}

	public static float NormalizeAngle(float degrees)
	{
		return 0f;
	}

	public static Quaternion InertiaY(Vector3 eulerFrom, Vector3 eulerTo, float speed)
	{
		return default;
	}

	public static Quaternion InertiaX(Vector3 eulerFrom, Vector3 eulerTo, float speed)
	{
		return default;
	}

	public static float Pow2(float val)
	{
		return 0f;
	}

	public static Matrix4x4 AbsMatrix(Matrix4x4 m)
	{
		return default;
	}

	public static Bounds FastAABBTransform(Matrix4x4 m, Bounds b)
	{
		return default;
	}
}
