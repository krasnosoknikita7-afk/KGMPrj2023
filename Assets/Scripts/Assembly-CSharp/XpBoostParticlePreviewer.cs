using UnityEngine;

public class XpBoostParticlePreviewer : MonoBehaviour
{
	private LayerFlags layersToRender;

	[SerializeField]
	public Camera previewCam;

	[SerializeField]
	private ParticleSystem xpBoostParticles;

	private bool isParticlesPlaying;

	private RenderTexture previewTexture;

	private const int lowResRT = 256;

	public bool IsParticlesPlaying => false;

	public RenderTexture PreviewTexture => null;

	public GameObject PreviewGameObject { get; private set; }

	public void FaceGameObject(GameObject go)
	{
	}

	public void OverrideCameraForPreviewer(Vector3 cameraAngle, Vector3 cameraOffset)
	{
	}

	public void Initialize(int textureWidth, int textureHeight, CameraClearFlags clearFlags, LayerFlags layersToRender, Vector3 cameraOffset, Vector3 previewPosition)
	{
	}

	public void StartParticleSystem()
	{
	}

	public void StopParticleSystem()
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
