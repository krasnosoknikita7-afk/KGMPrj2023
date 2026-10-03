using UnityEngine;

public class MaterialButtonTextureGenerator : MonoBehaviour
{
	public int previewResolution;

	[SerializeField]
	private MeshRenderer meshRenderer;

	[SerializeField]
	private MeshFilter meshFilter;

	[SerializeField]
	private Camera pictureCamera;

	[SerializeField]
	private Texture2D testTexture2D;

	private void Awake()
	{
	}

	public Texture2D TakePicture(Mesh mesh)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
