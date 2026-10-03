using UnityEngine;

public class SpawnRolePreviewer : MonoBehaviour
{
	[SerializeField]
	private Camera previewCam;

	[SerializeField]
	private GrayscaleEffect grayScaleEffect;

	[SerializeField]
	private GameObject blobShadowPrefab;

	private RenderTexture previewTexture;

	private LayerFlags layersToRender;

	private Vector3 previewCamOffset;

	private Vector3 pivotPoint;

	private MVBodyObject body;

	private GameObject rootObject;

	public RenderTexture PreviewTexture => null;

	private GameObject PreviewGameObject { get; set; }

	public void Initialize(int textureWidth, int textureHeight, CameraClearFlags clearFlags, LayerFlags layersToRender, Vector3 cameraOffset, Transform previewSpawnRoleRoot, Vector3 previewPosition, string name, int spawnRoleId, GameObject woGameObjectCopy)
	{
	}

	public void SetRenderGrey(bool shouldRenderAsGrey)
	{
	}

	public void StartActiveAnimation()
	{
	}

	public void StartInactiveAnimation()
	{
	}

	public void ActivatePreview()
	{
	}

	public void DeactivatePreview()
	{
	}

	private void OnPreCull()
	{
	}

	private void OnPostRender()
	{
	}

	private void OnDestroy()
	{
	}
}
