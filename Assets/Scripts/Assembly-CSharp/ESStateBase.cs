public class ESStateBase : IState
{
	protected EditorEvent stateType;

	protected WorldObjectClientRef tintedWo;

	private ILogger logger;

	private MVWorldObjectClientManager WOCM => null;

	private EditorEvent StateType => EditorEvent.EditCubes;

	public void SetStateType(EditorEvent stateTypeEvent)
	{
	}

	public virtual void Enter(EditorStateMachine esm)
	{
	}

	public virtual void Execute(EditorStateMachine e)
	{
	}

	public virtual void Exit(EditorStateMachine esm)
	{
	}

	public void Enter(FSMEntity e)
	{
	}

	public void Execute(FSMEntity e)
	{
	}

	public void Exit(FSMEntity e)
	{
	}

	protected void DeTintCurrent()
	{
	}

	protected static bool SelectionIsAllowedByLogicEnabled(int woId)
	{
		return false;
	}

	protected void TintObjectsOnMouseOver(EditorStateMachine e)
	{
	}

	protected void TintObjectsOnMouseOver(EditorStateMachine e, bool pickSuccess, VoxelHit hit)
	{
	}
}
