using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class MVCubeModelPrototypeTerrain : MVCubeModelBase
{
	private Dictionary<IntVector, CubeBase> removedCubes;

	public bool RequiresResetToEdit => false;

	public MVCubeModelPrototypeTerrain(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Destroy()
	{
	}

	public override void Select(Color color)
	{
	}

	public override void DeSelect()
	{
	}

	public ChunkInstances.ChunkInstanceVariables GetChunkInstance(IntVector chunkPos)
	{
		return default;
	}

	public Vector3 GetRandomCubePos()
	{
		return default;
	}

	public override void RemoveCubeNetworkUpdate(IntVector pos)
	{
	}

	public override void Reset()
	{
	}

	public bool RemovedCubesContainsKey(IntVector intVector)
	{
		return false;
	}
}
