using MV.WorldObject;
using UnityEngine;

public class ModelingDynamicBoxConstraint : ModelingBoxConstraint
{
	private MVCubeModelBase cubeModel;

	public ObscuredIntVector Size { get; private set; }

	public ModelingDynamicBoxConstraint(MVCubeModelBase cubeModel, IntVector constraintSize)
		: base(default)
	{
	}

	public void DetachFromCubeModel()
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

	private void CubeModel_Changed(CubeModelChangedEventArgs e)
	{
	}

	private Vector3 CalcConstraintBoxCenter(MVCubeModelBase model)
	{
		return default;
	}
}
