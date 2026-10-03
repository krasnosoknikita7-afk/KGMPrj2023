using UnityEngine;

public class ModelCursor3D : ModelCursor
{
	private IndentArea indentArea;

	public IndentArea IndentArea => null;

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

	public ModelCursor3D(Vector3[] cubeCorners)
		: base(null)
	{
	}

	public void SetIndentAreaSize(float size)
	{
	}

	public void UpdateCursor(CubePickingInfo movingEdgeCube, CubePickingInfo selectedCube, GameObject targetGameObject, BuildState buildState, bool addCube)
	{
	}

	public override void Remove()
	{
	}
}
