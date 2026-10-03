using System;
using MV.Common;
using MV.WorldObject;
using UnityEngine;

public static class RemoveCubes
{
	public static class RemoveCubesWithinRadius
	{
		private enum DestructionState
		{
			CompletelyDestroyed = 0,
			OnEdgeOfDestruction = 1,
			NotDestroyed = 2
		}

		private enum RemoveStyle
		{
			OnEdgeLeftUp = 0,
			OnEdgeRightUp = 1,
			OnEdgeRightDown = 2,
			OnEdgeLeftDown = 3,
			Completely = 4
		}

		private static class FallOffValues
		{
			private struct FallOffValue
			{
				public float squaredDistance;

				public float damage;

				public override string ToString()
				{
					return null;
				}
			}

			private const int maxNumFallOffValues = 20;

			private static int numFallOffValues;

			private static FallOffValue[] fallOffValues;

			private static int noDamageSquaredDistance;

			public static void TestFallOffValues(float radius, float centerDamage)
			{
			}

			public static void SetFallOffValues(float localRadius, float centerDamage)
			{
			}

			public static DestructionState GetDestructionState(float squaredDistance, float toughness)
			{
				return DestructionState.CompletelyDestroyed;
			}
		}

		private static class CornerCubes
		{
			private static readonly byte[][] cornerCubes;

			public static byte[] GetCornerCube(int index)
			{
				return null;
			}
		}

		private const float SQRT_3_DIV_2 = 0.8660254f;

		private const float SQRT_3 = 1.7320508f;

		private static float localRadiusExtendedSquared;

		private static float localRadiusReducedSquared;

		private static IntVector iterationBounds;

		private static IntVector localMin;

		private static Vector3 localPosition;

		private static float centerDamage;

		private static DamageFallOffType damageFallOffType;

		public static void TestFallOffValues(float radius, float centerDamage)
		{
		}

		public static bool HandleRemoveCubes(MVCubeModelBase cm, float radius, IntVector fineGrainedTerrainLocalPos, float centerDamage, DamageFallOffType damageFallOffType, MVCubeModelBase fineGrainedTerrainWorldObject, Func<byte, PhysicalProperties> getPhysicalProperites)
		{
			return false;
		}

		private static void CalculateLocalValues(MVCubeModelBase cm, float radius, IntVector localCenterPosition)
		{
		}

		private static bool RemoveCubesTerrain(MVCubeModelBase wo, MVCubeModelBase fineGrainedTerrain, Func<byte, PhysicalProperties> getPhysicalProperites)
		{
			return false;
		}

		private static bool RemoveCube(DestructionState destructionState, MVCubeModelBase wo, MVCubeModelBase fineGrainedTerrain, IntVector testPosition)
		{
			return false;
		}

		private static bool RemoveCubesSmooth(MVCubeModelBase wo, Func<byte, PhysicalProperties> getPhysicalProperites)
		{
			return false;
		}

		private static bool CubeCornersEqual(byte[] corners0, byte[] corners1)
		{
			return false;
		}

		private static RemoveStyle HandleCubeOnRadiusLimit(MVCubeModelBase wo, int x, IntVector pos, bool fromDestroyToNotDestroy, Func<byte, PhysicalProperties> getPhysicalProperites)
		{
			return RemoveStyle.OnEdgeLeftUp;
		}

		private static DestructionState CalculateCubeDestruction(IntVector cubePos, CubeBase cubeBase, Func<byte, PhysicalProperties> getPhysicalProperites)
		{
			return DestructionState.CompletelyDestroyed;
		}

		private static DestructionState NoFallOffDestruction(float testDistSqr, float toughness)
		{
			return DestructionState.CompletelyDestroyed;
		}

		private static DestructionState LinearDestruction(float testDistSqr, float toughness)
		{
			return DestructionState.CompletelyDestroyed;
		}
	}

	public static class RemoveOneCube
	{
		public static bool HandleRemoveOneCube(IntVector fineGrainedPosition, ICubeModel terrainWorldObject, ICubeModel fineGrainedTerrainWorldObject)
		{
			return false;
		}

		public static CubeDamageState CanRemoveCube(CubeBase cubeBase, float damage, Func<byte, PhysicalProperties> getPhysicalProperites)
		{
			return CubeDamageState.NoDamage;
		}

		private static bool TryRemoveCubeFromTerrain(IntVector fineGrainedPosition, ICubeModel terrainWorldObject, ICubeModel fineGrainedTerrainWorldObject)
		{
			return false;
		}

		private static bool TryRemoveCubeFromFineGrainedTerrain(IntVector fineGrainedPosition, ICubeModel fineGrainedTerrainWorldObject)
		{
			return false;
		}
	}
}
