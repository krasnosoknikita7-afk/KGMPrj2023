using UnityEngine;

public class ConstraintVisualizer : MonoBehaviour
{
	private IModelingConstraint constraint;

	public void Init(MVCubeModelBase targetCubeModel, IModelingConstraint constraint, string layer = "UIItems")
	{
	}

	private void OnDestroy()
	{
	}

	private void Constraint_BoxChanged(object sender, ConstraintBoxChangedEventArgs e)
	{
	}

	private void CreateInsideOutCube()
	{
	}

	private void BuildMesh(Vector3[] vertices)
	{
	}
}
