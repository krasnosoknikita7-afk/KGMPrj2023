using MV.WorldObject;
using UnityEngine;

public class CubePickingInfo
{
	public Cube cube;

	public Face pickedFace;

	public Edge pickedEdge;

	public bool pickedEdgeIndex0;

	public bool pickedEdgeIndex1;

	public Vector3 normal;

	public Vector3 point;

	public IntVector iLocalPos;

	public CubePickingInfo()
	{
	}

	public CubePickingInfo(CubePickingInfo cubePickingInfo)
	{
	}
}
