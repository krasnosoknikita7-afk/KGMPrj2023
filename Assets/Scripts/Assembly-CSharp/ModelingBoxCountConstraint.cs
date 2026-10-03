using MV.WorldObject;

public class ModelingBoxCountConstraint : ModelingBoxConstraint
{
	private MVCubeModelBase cubeModel;

	private int minCubesCount;

	public ModelingBoxCountConstraint(MVCubeModelBase cubeModel, IntVector minCorner, IntVector maxCorner, int minCubeCount)
		: base(default)
	{
	}

	public override bool CanAddCubeAt(IntVector pos)
	{
		return false;
	}

	public override bool CanRemoveCubeAt(IntVector pos)
	{
		return false;
	}

	public override bool CanEditCubeAt(IntVector pos)
	{
		return false;
	}

	private void CubeModel_Changed(object sender, CubeModelChangedEventArgs e)
	{
	}
}
