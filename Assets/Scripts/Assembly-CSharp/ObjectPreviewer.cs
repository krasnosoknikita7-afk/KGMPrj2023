using UnityEngine;

public class ObjectPreviewer : MonoBehaviour
{
	private const float previewObjMaxSize = 2f;

	private const float previewCamAdditionalHeight = 1.2f;

	private const float previewCamDist = 2.2f;

	private const float previewItemRotateSpeed = 9.3f;

	private static int previewerIndex;

	private Vector3 previewCamOffset;

	public LayerFlags layersToRender;

	private Camera previewCam;

	private Vector3 pivotPoint;

	public RenderTexture PreviewTexture { get; private set; }

	public GameObject PreviewGameObject { get; private set; }

	public static ObjectPreviewer Create(int textureSize, CameraClearFlags clearFlags, LayerFlags layersToRender, Transform previewItemsRoot, string name, GameObject woGameObjectCopy)
	{
		return null;
	}

	public static ObjectPreviewer Create(int textureSize, CameraClearFlags clearFlags, LayerFlags layersToRender, Vector3 cameraOffset, Transform previewItemsRoot, Vector3 previewPosition, string name, MVWorldObjectClient wo, GameObject woGameObjectCopy)
	{
		return null;
	}

	public static ObjectPreviewer Create(int textureWidth, int textureHeight, CameraClearFlags clearFlags, LayerFlags layersToRender, Vector3 cameraOffset, Transform previewItemsRoot, Vector3 previewPosition, string name, MVWorldObjectClient wo, GameObject woGameObjectCopy)
	{
		return null;
	}

	private static Bounds ComputeLocalBounds(GameObject go)
	{
		return default;
	}

	private void OnPreCull()
	{
	}

	private void OnPostRender()
	{
	}

	private ObjectPreviewer()
	{
	}

	public void UpdateRotation(float rotateSpeed = 0f)
	{
	}

	public void Destroy()
	{
	}
}
