using System.Collections.Generic;
using UnityEngine;

public class InventoryItemPreviewer : MonoBehaviour
{
	private const float PreviewObjMaxSize = 2f;

	private const float PreviewItemRotateSpeed = 9.3f;

	private Vector3 previewCamOffset;

	private readonly Vector3 inventoryItemStandardOffset;

	private LayerFlags layersToRender;

	[SerializeField]
	public Camera previewCam;

	private RenderTexture previewTexture;

	private Vector3 pivotPoint;

	private readonly Dictionary<MVWorldObjectDocumentationType, float> WorldObjectCameraFOVOverload;

	public RenderTexture PreviewTexture => null;

	public GameObject PreviewGameObject { get; private set; }

	public void Initialize(int textureWidth, int textureHeight, CameraClearFlags clearFlags, LayerFlags layersToRender, Vector3 cameraOffset, Transform previewItemsRoot, Vector3 previewPosition, string name, MVWorldObjectClient wo, GameObject woGameObjectCopy)
	{
	}

	private void OnPreCull()
	{
	}

	private void OnPostRender()
	{
	}

	public void UpdateRotation(float rotateSpeed = 0f)
	{
	}

	private void OnDestroy()
	{
	}
}
