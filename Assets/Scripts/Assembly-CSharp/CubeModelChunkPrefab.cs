using UnityEngine;

public class CubeModelChunkPrefab : MonoBehaviour
{
	[SerializeField]
	private MeshFilter meshFilter;

	[SerializeField]
	private MeshRenderer meshRenderer;

	[SerializeField]
	private BoxCollider boxCollider;

	public MeshFilter MeshFilter => null;

	public MeshRenderer MeshRenderer => null;

	public BoxCollider BoxCollider => null;
}
