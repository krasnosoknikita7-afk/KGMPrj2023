using UnityEngine;

public class SentryGunScript : MonoBehaviour
{
	public MeshRenderer sentryRenderer;

	public Transform glowPlane;

	public Material materialFireBeam;

	public Material materialIceBeam;

	public AudioClip audioClipFireBeam;

	public AudioClip audioClipIceBeam;

	public Material blinkDamageMaterial;

	public GameObject smokeEffect;

	public Transform healthPivot;

	[SerializeField]
	private Mesh sentryMesh;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private ParticleSystem smokeEffectEmitter;

	[SerializeField]
	private Renderer glowPlaneRenderer;

	private Color color;

	private SphereVolumeIndicator rangeVisualization;

	private float damageBlinkTimeoutTime;

	private Camera mainCamera;

	protected void Awake()
	{
	}

	public void EnableSmoke()
	{
	}

	public void DisableSmoke()
	{
	}

	public void Explode()
	{
	}

	public void BlinkDamage()
	{
	}

	public void SetHealth(float value)
	{
	}

	public void SetGlowFactor(float glow)
	{
	}

	public void UpdateAnimation()
	{
	}

	public void SetLaserRange(float range)
	{
	}

	public void SetSentryGunBeamType(SentryGunBeamType beamType)
	{
	}

	private void SetActiveMaterial(SentryGunBeamType beamType)
	{
	}

	private void SetSound(SentryGunBeamType beamType)
	{
	}

	private void LateUpdate()
	{
	}
}
