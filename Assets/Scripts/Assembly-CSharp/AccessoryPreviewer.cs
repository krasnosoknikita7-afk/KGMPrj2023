using UnityEngine;

public class AccessoryPreviewer : MonoBehaviour
{
	private RenderTexture previewTexture;

	private Camera previewCam;

	private GameObject previewGameObject;

	private LayerFlags layersToRender;

	private static Vector3 previewPosition;

	private Transform rootTransform;

	private Vector3 pivotPoint;

	public RenderTexture PreviewTexture => null;

	public void Initialize(int textureWidth, int textureHeight, LayerFlags layersToRender, CameraClearFlags clearFlags, Vector3 cameraPosOffset, Vector3 cameraRotOffset, GameObject woGameObjectCopy, Transform rootTransform)
	{
	}

	private static Bounds ComputeLocalBounds(GameObject go)
	{
		return default;
	}

	public void Destroy()
	{
	}

	private void OnPreCull()
	{
	}

	private void OnPostRender()
	{
	}
}
