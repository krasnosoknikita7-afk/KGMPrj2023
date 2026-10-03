using MV.WorldObject;
using UnityEngine;

public class CellCursorCubeMesh
{
	private IntVector pos;

	private float fadeOutTime;

	private float prevCursorSetTime;

	private GameObject gameObject;

	public float PrevCursorSetTime => 0f;

	public IntVector LocalPos => default;

	public GameObject GameObject => null;

	public void SetCursorCube(IntVector position, GameObject cubeGameObject)
	{
	}

	public void Update()
	{
	}

	public void Destroy()
	{
	}
}
