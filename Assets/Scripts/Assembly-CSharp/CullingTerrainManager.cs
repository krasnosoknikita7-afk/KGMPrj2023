using System.Collections.Generic;
using MV.WorldObject;

public class CullingTerrainManager
{
	private readonly ChunkInstances chunkInstances;

	private readonly MVCubeModelBase cubeModelBase;

	private Dictionary<IntVector, CullingSubscriberTerrainChunk> terrainCullingSubscriberBases;

	public CullingTerrainManager(ChunkInstances chunkInstances, MVCubeModelBase cubeModelBase)
	{
	}

	private void ChunkInstancesOnChanged(object sender, ChunkInstancesChanged chunkInstancesChanged)
	{
	}

	private void OnChanged(HashSet<IntVector> chunksChanged)
	{
	}

	private void CreateCullingSubscriber(IntVector chunkPos, ChunkInstances.ChunkInstanceVariables chunk)
	{
	}

	public void Clear()
	{
	}

	private void DestroyCullingSubscribers()
	{
	}
}
