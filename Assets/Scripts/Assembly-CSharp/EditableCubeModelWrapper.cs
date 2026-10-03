using MV.WorldObject;

public class EditableCubeModelWrapper
{
	private MVCubeModelInstance cubeModelBase;

	public MVCubeModelInstance CubeModel => null;

	public EditableCubeModelWrapper(MVCubeModelInstance cubeModelBase)
	{
	}

	public EditableCubeModelWrapper(MVCubeModelInstance cubeModelBase, IntVector min, IntVector max, int minCubeCount)
	{
	}

	public virtual bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}

	public virtual bool OnExitObject(EditorStateMachine e)
	{
		return false;
	}

	protected void SetConstraints(IntVector min, IntVector max, int minCubeCount)
	{
	}
}
