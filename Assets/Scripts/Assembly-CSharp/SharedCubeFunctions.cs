using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

internal static class SharedCubeFunctions
{
	private static readonly IntVector constraint;

	public const float LowestCubeSize = 0.0625f;

	public const float CubeSegmentSize = 0.25f;

	public const float Gridsize = 1f;

	public const float NoneGridSize = 0.0625f;

	private const float forceEdgeDistance = 0.15f;

	public static IntVector[][] LightTestOffsets;

	public static IntVector[][] LightTestOffsetsInside;

	public static IntVector CubeConstraint => default;

	public static Vector3 CubeConstraintVector3 => default;

	public static void AddCubeMeshCubeLines(Mesh mesh, Vector3[] corners, float diagonalWidth)
	{
	}

	public static void AddCubeLine(Mesh mesh, Vector3 p0, Vector3 p1, float diagonalWidth)
	{
	}

	public static void AddCubeMesh(Mesh mesh, Vector3[] corners, bool insideOut)
	{
	}

	public static Vector3[] GetCorners()
	{
		return null;
	}

	public static Vector3[] GetCorners(Bounds bounds)
	{
		return null;
	}

	public static Vector3[] GetCorners(Vector3 min, Vector3 max)
	{
		return null;
	}

	public static Vector3[] GetVertices()
	{
		return null;
	}

	public static Vector3[] GetVertices(Vector3[] corners)
	{
		return null;
	}

	public static Vector3 GetClosestGridPoint(Vector3 worldPosition, Quaternion rotation, float gridSize, Vector3 scale)
	{
		return default;
	}

	public static IntVector WorldToLocal(GameObject gameObject, Vector3 point, bool floor = false)
	{
		return default;
	}

	public static Vector3 WorldPosToValidGridPos(GameObject gameObject, Vector3 worldPos, int cubeSegments)
	{
		return default;
	}

	public static Vector3 LocalToWorld(GameObject gameObject, IntVector iVector)
	{
		return default;
	}

	public static Dictionary<IntVector, Cube> CreateFromBytePackage(BytePacker bp)
	{
		return null;
	}

	public static Bounds? GetAxisAlignedBoundsRecursively(Transform transform)
	{
		return null;
	}

	private static Vector3[] GetTriangleVertices(int triangleIndex, GameObject gameObject)
	{
		return null;
	}

	public static float ScaleFactor(GameObject gameObject)
	{
		return 0f;
	}

	public static float ScaleFactor(GameObject gameObject, Face face)
	{
		return 0f;
	}

	public static CubeOutOfBoundState MoveEdge(MVCubeModelBase cmb, CubePickingInfo info, Vector3 mousePositionDelta, ref float delta, ref float deltaAccum, float mouseSensitivity, ref bool edgeMoved, bool edgeIndex0, bool edgeIndex1, ref EditCubeChange editCubeChange)
	{
		return CubeOutOfBoundState.WithinBounds;
	}

	public static void GetVertices(CubePickingInfo info, GameObject gameObject)
	{
	}

	public static Bounds? GetAxisAlignedBoundsRecursively(List<MVWorldObjectClient> wos)
	{
		return null;
	}

	public static Bounds? GetAxisAlignedBoundsRecursively(List<Transform> transforms)
	{
		return null;
	}

	public static Vector3 GetWorldCenter(List<Transform> transforms)
	{
		return default;
	}

	public static Vector3 GetWorldCenter(Transform transform)
	{
		return default;
	}

	public static void SetLayerRecursively(Transform t, bool select)
	{
	}

	public static IntVector CubePosToChunk(IntVector cubePos, int chunkSize)
	{
		return default;
	}
}
