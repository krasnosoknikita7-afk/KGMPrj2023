using System.Collections.Generic;
using MV.WorldObject;

public class MVCubeModelFineGrainedTerrain : MVCubeModelBase
{
	private CullingTerrainManager cullingTerrainManager;

	public bool RequiresResetToEdit => false;

	public MVCubeModelFineGrainedTerrain(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Destroy()
	{
	}

	public override void Reset()
	{
	}

	public override void RemoveCubeNetworkUpdate(IntVector pos)
	{
	}

	public override void AddCubeNetworkUpdate(IntVector pos, CubeBase cube)
	{
	}
}
