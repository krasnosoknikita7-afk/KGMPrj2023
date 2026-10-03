internal class ESCubeEdit : ESStateBase
{
	private IModelingConstraint constraint;

	private ConstraintVisualizer constraintVisualizer;

	private int targetCubeModelId;

	private bool exiting;

	private MVCubeModelBase TargetCubeModel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void Enter(EditorStateMachine e)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	public override void Exit(EditorStateMachine e)
	{
	}

	private void Exit()
	{
	}

	private void HandleUnavailableMaterial(EditorStateMachine e)
	{
	}
}
