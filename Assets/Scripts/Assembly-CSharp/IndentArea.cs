using UnityEngine;

public class IndentArea : ICursor
{
	private Material materialEdge;

	private Material materialNone;

	private Camera mainCamera;

	private GameObject gameObject;

	private float size;

	public GameObject GameObject => null;

	public float Size
	{
		set
		{
		}
	}

	public void Remove()
	{
	}

	public void UpdateIndentArea(CubePickingInfo info, GameObject cubeGameObject)
	{
	}

	public bool IsColliding()
	{
		return false;
	}

	private Vector2[] SetUVs()
	{
		return null;
	}
}
