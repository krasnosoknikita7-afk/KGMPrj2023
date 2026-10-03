using UnityEngine;

public struct SharedMeshData
{
	public Mesh mesh;

	public Material material;

	public SharedMeshData(Mesh mesh)
	{
		this.mesh = null;
		material = null;
	}

	public void SetToMesh(ref Mesh mesh, ref Material material)
	{
	}

	public void Destroy()
	{
	}
}
