using UnityEngine;

public class FaceCursor : ICursor
{
	private Material materialCorner;

	private Material materialEdge;

	private Material materialNone;

	private GameObject gameObject;

	public GameObject GameObject => null;

	public FaceCursor(Material materialEdgePath, Material materialCornerPath, Material materialNonePath)
	{
	}

	public void Remove()
	{
	}

	public void UpdateCursor(CubePickingInfo info, GameObject cubeGameObject)
	{
	}

	private Vector2[] SetUVs(Edge edge, bool mirror)
	{
		return null;
	}
}
