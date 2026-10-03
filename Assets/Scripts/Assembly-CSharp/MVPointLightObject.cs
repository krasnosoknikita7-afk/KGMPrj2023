using UnityEngine;

public class MVPointLightObject : ObjectPrefab
{
	[SerializeField]
	private Light pointLight;

	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private StreamedTextureToMeshRenderer streamedTexture;

	[SerializeField]
	private MeshRenderer pointLightPlaneMesh;

	[SerializeField]
	private Transform pointLightPlaneTransform;

	public GameObject VisualObject => null;

	public Light PointLight => null;

	public StreamedTextureToMeshRenderer StreamedTexture => null;

	public MeshRenderer PointLightPlaneMesh => null;

	public Transform PointLightPlaneTransform => null;
}
