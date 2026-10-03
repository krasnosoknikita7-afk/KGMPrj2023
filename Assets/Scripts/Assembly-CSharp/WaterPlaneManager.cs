using UnityEngine;

public class WaterPlaneManager : MonoBehaviour
{
	private const float avatarHeight = 2.1f;

	[SerializeField]
	private Water water;

	[SerializeField]
	private Transform underwaterCameraPlane;

	[SerializeField]
	private SplashController splashController;

	private Renderer underwaterCameraPlaneRenderer;

	private AudioLowPassFilter lowPassFilter;

	private AudioReverbFilter reverbFilter;

	private MVWaterPlane waterPlaneLogicCube;

	private SkyboxManager skyboxManager;

	private Camera mainCamera;

	private bool audioHD;

	public SplashController Splash => null;

	public bool IsActive => false;

	public float WaterLevel => 0f;

	public Color WaterColor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public bool IsLethal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	protected void Start()
	{
	}

	protected void Update()
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	public void AddWaterPlaneLogicCube(MVWaterPlane logicCube)
	{
	}

	public void RemoveWaterPlaneLogicCube(MVWaterPlane wp)
	{
	}

	public float ComputeAvatarWaterProximity(Vector3 position)
	{
		return 0f;
	}

	public float GetHeightAboveWaterLevel(Vector3 position)
	{
		return 0f;
	}

	public float GetHeightAboveWaterLevel(float altitude)
	{
		return 0f;
	}

	private void UpdateUnderwaterCameraEffects()
	{
	}

	private void HandleSkyboxColorChanged(Color newColor)
	{
	}

	private void HandleQualityChanged(int level)
	{
	}
}
