using MV.WorldObject;

internal class EditCubes : CubeModelTool
{
	private float delta;

	private float deltaAccum;

	private byte prevMaterial;

	private bool edgeHasMoved;

	private float mouseSensitivity;

	private const float MouseSensitivityExtrude = 2.02f;

	private const float MouseUpTimeBeforeMoveEdge = 0.3f;

	private const float DetailEditModeMaxDistance = 30f;

	private float prevMouseUpTime;

	private BuildState currentInternalState;

	private CubePickingInfo prevSelectedCube;

	private CubePickingInfo movingEdgeCube;

	private Cube prevCubeState;

	private ModelCursor3D modelCursor;

	public override bool CursorVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private static void DebugLog(string msg)
	{
	}

	public override void Enter(CubeModelingStateMachine e)
	{
	}

	public override void Execute(CubeModelingStateMachine e)
	{
	}

	public override void Exit(CubeModelingStateMachine e)
	{
	}

	public override void HideCursor()
	{
	}

	private bool GotoMultiChangeCubes()
	{
		return false;
	}

	private static IntVector GetCubePosNeighborOppositeFace(IntVector localPos, Face face)
	{
		return default;
	}

	private void SetEditDetail(CubeModelingStateMachine e)
	{
	}
}
