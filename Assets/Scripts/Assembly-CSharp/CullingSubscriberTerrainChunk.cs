using MV.WorldObject;
using UnityEngine;

public class CullingSubscriberTerrainChunk : ICullingSubscriber
{
	private readonly IntVector chunkPosition;

	private readonly MVCubeModelBase cubeModelBase;

	private int distanceBand;

	public int CullingIndex { get; set; }

	public CullingSubscriberTerrainChunk(MVCubeModelBase cubeModelBase, IntVector chunkPosition, Bounds bounds)
	{
	}

	public void Setup(Bounds bounds)
	{
	}

	public void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	public void HandleChange()
	{
	}

	public void Destroy()
	{
	}
}
