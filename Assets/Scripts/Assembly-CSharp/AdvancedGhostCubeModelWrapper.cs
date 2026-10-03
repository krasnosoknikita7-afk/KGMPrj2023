using UnityEngine;

public class AdvancedGhostCubeModelWrapper : EditableCubeModelWrapper
{
	private Transform transformParent;

	private bool cubeModelIsBeingEdited;

	public bool CubeModelIsBeingEdited => false;

	public AdvancedGhostCubeModelWrapper(MVCubeModelInstance cubeModelBase, Transform transformParent)
		: base(null)
	{
	}

	public bool OnEnterObject(EditorStateMachine e, Transform transform)
	{
		return false;
	}

	public override bool OnExitObject(EditorStateMachine e)
	{
		return false;
	}

	private void EnterEdit(Transform transform)
	{
	}

	public void ExitEdit()
	{
	}

	private void SetToTransformParent()
	{
	}
}
