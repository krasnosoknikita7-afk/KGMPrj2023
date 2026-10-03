using System.Collections.Generic;
using MV.WorldObject;

public class TerrainLODComponent
{
	private class TriangleCounter
	{
		private HashSet<IntVector> enabledChunks;

		public void Add(IntVector localPos)
		{
		}

		public void Remove(IntVector localPos)
		{
		}

		public int GetEnabledTriangleCount(RuntimePrototypeCubeModel prototypeCubeModel)
		{
			return 0;
		}
	}

	private List<MVTerrainLOD> LODBookkeeping;

	private int currentLODPosition;

	private readonly TriangleCounter triangleCounter;

	private readonly ChunkInstances chunkInstances;

	private readonly RuntimePrototypeCubeModel prototypeCubeModel;

	private readonly DynamicLODDistance dynamicLodDistance;

	private bool debug;

	private float scale;

	public TerrainLODComponent(RuntimePrototypeCubeModel prototypeCubeModel, ChunkInstances chunkInstances, DynamicLODDistance dynamicLodDistance, float scale, bool debug)
	{
	}

	public void ChangeLODTerrain()
	{
	}

	private void chunkInstances_Changed(object sender, ChunkInstancesChanged e)
	{
	}

	private void AddToLOD(IntVector localPos)
	{
	}

	private void ChangeLODChunk(ChunkInstances.ChunkInstanceVariables chunk, ref IntVector chunkPosition, float distance, float renderDistance)
	{
	}
}
