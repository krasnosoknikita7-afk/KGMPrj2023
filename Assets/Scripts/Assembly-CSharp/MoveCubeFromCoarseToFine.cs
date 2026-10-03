using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public static class MoveCubeFromCoarseToFine
{
	private class ValidPos
	{
		public bool valid;

		public Vector3 pos;

		public ValidPos(bool valid, Vector3 pos)
		{
		}
	}

	private static IntVector[] intCubeCorners;

	public static void MoveCube(ICubeModel from, ICubeModel to, IntVector fromPos)
	{
	}

	private static void AddUnindentedCube(ICubeModel from, ICubeModel to, IntVector fromPos)
	{
	}

	private static void AddIndentedCube(ICubeModel from, ICubeModel to, IntVector fromPos)
	{
	}

	private static List<Plane> GetTestPlanes(ICubeModel from, IntVector fromPos)
	{
		return null;
	}

	private static List<ValidPos> CreateValidPosGrid(int scaleFactor)
	{
		return null;
	}

	private static List<IntVector> GetValidCubes(List<ValidPos> validPoses, int scaleFactor)
	{
		return null;
	}

	private static int IntVectorToValidPosIndex(IntVector intVector, int validPosSize)
	{
		return 0;
	}

	private static void SetValidPoints(List<Plane> testPlanes, List<ValidPos> validPoses)
	{
	}

	private static bool IsFaceIndented(Face face, ref Vector3[] faceCorners)
	{
		return false;
	}
}
