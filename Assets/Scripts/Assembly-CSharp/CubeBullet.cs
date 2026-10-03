using UnityEngine;

public class CubeBullet : MonoBehaviour
{
	[SerializeField]
	private MeshFilter meshFilter;

	[SerializeField]
	private MeshRenderer meshRenderer;

	public byte MaterialID { get; private set; }

	public MeshFilter MeshFilter => null;

	public MeshRenderer MeshRenderer => null;

	private void Update()
	{
	}

	public void SetCubeMaterial(byte id)
	{
	}
}
