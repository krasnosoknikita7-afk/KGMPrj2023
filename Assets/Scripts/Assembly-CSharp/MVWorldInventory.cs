using System.Collections.Generic;

public class MVWorldInventory
{
	public delegate void OnWorldInventoryChangeDelegate(MVWorldInventory inventory);

	private Dictionary<int, RuntimePrototypeCubeModel> runtimePrototypes;

	private Dictionary<int, PendingPrototypeData> pendingRuntimePrototypes;

	private List<RuntimePrototypeCubeModel> dirtyRPCM;

	private const int numberOfLowPriorityMeshGenerations = 1;

	public OnWorldInventoryChangeDelegate OnWorldInventoryChange;

	public Dictionary<int, RuntimePrototypeCubeModel> RuntimePrototypes => null;

	public void AddRuntimePrototypeToDirty(RuntimePrototypeCubeModel rpcm)
	{
	}

	public void OnUpdatePrototypeEvent(int worldInventoryID, byte[] worldInventoryData)
	{
	}

	public void OnUpdatePrototypeScaleEvent(int worldInventoryID, float scale)
	{
	}

	private void GenerateAllDirty(ref int counter)
	{
	}

	private bool GenerateDirty(MeshGeneratePriority priority, ref int counter)
	{
		return false;
	}

	private void GenerateDirtyRPCM()
	{
	}

	public void LateUpdate()
	{
	}

	public void AddPrototype(Dictionary<object, object> data)
	{
	}

	public void RemovePrototype(int id)
	{
	}

	public void UnpendRuntimePrototype(int woId)
	{
	}

	public void OnReplaceWoPrototype(int woId, int worldInventoryId)
	{
	}

	public void RequestWoMakeUniquePrototype(int woId)
	{
	}

	private void ReplaceWithPendingRuntimePrototype(int woId)
	{
	}

	private RuntimePrototypeCubeModel CreatePendingPrototype(int prototypeId)
	{
		return null;
	}

	private void NotifyWorldInventoryChange()
	{
	}
}
