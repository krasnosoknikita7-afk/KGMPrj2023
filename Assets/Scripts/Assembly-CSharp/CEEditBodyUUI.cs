public class CEEditBodyUUI : ESStateBase
{
	private ConstraintVisualizer constraintVisualizer;

	private IWorldObjectWithModelingConstraint modelBody;

	private int targetCubeModelId;

	private MVCubeModelInstance TargetCubeModel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void Enter(EditorStateMachine esm)
	{
	}

	public override void Execute(EditorStateMachine esm)
	{
	}

	public override void Exit(EditorStateMachine esm)
	{
	}
}
