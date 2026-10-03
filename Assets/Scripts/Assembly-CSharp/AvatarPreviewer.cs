using UnityEngine;

public class AvatarPreviewer : MonoBehaviour
{
	private float previewObjMaxSize;

	private float previewCamAdditionalHeight;

	private float previewCamDist;

	private LayerFlags layersToRender;

	[SerializeField]
	public Camera previewCam;

	private RenderTexture previewTexture;

	private Vector3 pivotPoint;

	private const int lowResRT = 256;

	public RenderTexture PreviewTexture => null;

	public GameObject PreviewGameObject { get; private set; }

	public void FaceGameObject(GameObject go)
	{
	}

	public void OverrideCameraForPreviewer(Vector3 cameraAngle, Vector3 cameraOffset)
	{
	}

	public void Initialize(int textureWidth, int textureHeight, CameraClearFlags clearFlags, LayerFlags layersToRender, Vector3 cameraOffset, Transform previewItemsRoot, Vector3 previewPosition, string name, MVWorldObjectClient wo, GameObject woGameObjectCopy, Vector3 additionalCameraRotation)
	{
	}

	private void OnPreCull()
	{
	}

	private void OnPostRender()
	{
	}

	public void UpdateRotation(float rotateSpeed)
	{
	}

	private void OnDestroy()
	{
	}
}
