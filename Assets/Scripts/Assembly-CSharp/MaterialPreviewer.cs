using UnityEngine;

public class MaterialPreviewer : MonoBehaviour
{
	public RenderTexture renderTexture;

	public int previewResolution;

	[SerializeField]
	private MeshRenderer meshRenderer;

	[SerializeField]
	private MeshFilter meshFilter;

	[SerializeField]
	private Camera pictureCamera;

	[SerializeField]
	private Transform cube;

	private void Awake()
	{
	}

	public void Initialize(Mesh mesh)
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}
}
