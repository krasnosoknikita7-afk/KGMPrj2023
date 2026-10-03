using MV.WorldObject;
using UnityEngine;

public class CellCursorCubeLineMesh
{
	private IntVector pos;

	private float fadeOutTime;

	private float baseAlpha;

	private float prevCursorSetTime;

	private GameObject gameObject;

	private static readonly int ColorID;

	private Material flashingMaterial;

	private float flashingTimer;

	private readonly MeshRenderer meshRenderer;

	public float PrevCursorSetTime => 0f;

	public IntVector LocalPos => default;

	public GameObject GameObject => null;

	public CellCursorCubeLineMesh(float diagonalWidth, Material material, float fadeOutTime, Vector3[] cubeCorners)
	{
	}

	public void SetCursorCube(IntVector position, GameObject cubeGameObject)
	{
	}

	public void Update()
	{
	}

	public void Destroy()
	{
	}

	public void ChangeMaterial(Material material)
	{
	}
}
