using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class CellCursor : ICursor
{
	private List<CellCursorCubeLineMesh> cursorCubes;

	public bool Active
	{
		set
		{
		}
	}

	public CellCursor(int cursorCubeCount, float diagonalWidth, Material material, float fadeOutTime, Vector3[] cubeCorners)
	{
	}

	public void Remove()
	{
	}

	public CellCursorCubeLineMesh GetCellCursor(IntVector iLocalPos)
	{
		return null;
	}

	public void SetCursor(CubePickingInfo info, GameObject cubeGameObject)
	{
	}

	public void SetCursor(IntVector position, GameObject cubeGameObject)
	{
	}

	public void UpdateCursor()
	{
	}

	private IntVector GetCubeCursorPos(CubePickingInfo info)
	{
		return default;
	}

	public void ChangeMaterial(Material material)
	{
	}
}
