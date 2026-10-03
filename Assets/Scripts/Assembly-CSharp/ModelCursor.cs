using MV.WorldObject;
using UnityEngine;

public class ModelCursor
{
	protected FaceCursor faceCursor;

	protected readonly CellCursor errorCursor;

	private const float addCubeLaserOnTime = 0.2f;

	public virtual bool CursorVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ModelCursor(Vector3[] cubeCorners)
	{
	}

	private void HandleLaserMovingEdge(CubePickingInfo movingEdgeCube, GameObject targetGameObject)
	{
	}

	protected void HandleLaser(CubePickingInfo movingEdgeCube, CubePickingInfo selectedCube, GameObject targetGameObject, BuildState buildState, bool addCube)
	{
	}

	public void SetErrorCursor(IntVector iPos, GameObject targetGameObject, bool showUnlockNotification)
	{
	}

	public static void ShowUnlockMaterialNotification()
	{
	}

	public virtual void Remove()
	{
	}
}
