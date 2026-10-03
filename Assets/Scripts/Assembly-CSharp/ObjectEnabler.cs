using UnityEngine;

public class ObjectEnabler : MonoBehaviour, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	public MVObjectEnabler woObjectEnabler;

	private Material objectMaterial;

	private int nameToLayer;

	private float currentAlpha;

	private Camera mainCamera;

	public bool IsDrawingEnabled { get; set; }

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public void Initialize()
	{
	}

	private void DrawObject(MeshFilter[] previewMeshes)
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}
}
