internal class ESTerrainEdit : ESStateBase
{
	private MVCubeModelPrototypeTerrain terrain;

	public override void Enter(EditorStateMachine e)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	private bool ResettingTerrain(VoxelHit targetHit)
	{
		return false;
	}

	public override void Exit(EditorStateMachine e)
	{
	}
}
