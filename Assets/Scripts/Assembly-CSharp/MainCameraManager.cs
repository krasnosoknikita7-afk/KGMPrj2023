using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MV.Common;
using UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class MainCameraManager : MonoBehaviour
{
	[SerializeField]
	private Camera mainCamera;

	[SerializeField]
	private Transform secondaryCamera;

	[SerializeField]
	private Transform tertiaryCamera;

	[SerializeField]
	private TransitionCamera transitionCamera;

	[SerializeField]
	private AudioSource plingSound;

	[SerializeField]
	private GrayscaleEffect greyScaleEffect;

	[SerializeField]
	private Skybox skybox;

	[SerializeField]
	private LineDrawManager lineDrawManager;

	[SerializeField]
	private ScreenSizeOptimizer screenSizeOptimizer;

	[SerializeField]
	private PostProcessLayer postProcessLayer;

	[SerializeField]
	private PostProcessVolume postProcessVolume;

	[SerializeField]
	public PostProcessResources postProcessResources;

	public static PostProcessingSettings CurrentPostProcessingSettings;

	private MVCameraController cameraController;

	private bool isLogicRendered;

	private static Dictionary<MVGameType, ICameraSettings> cameraSettings;

	public Shader transparentMultiplyColor;

	[CompilerGenerated]
	private EventHandler<OnIgnoreInputTypesArgs> m_onIgnoreInputTypes;

	private bool blueModeEnabled;

	public static float DistanceToAvatarBase;

	public static CameraType DefaultCameraType;

	public static bool IsCameraForcedFirstPerson;

	private ProtectedTransform protectedTransform;

	private static float baseVolume;

	private static bool mute;

	private static bool gameHasCameraEffects;

	private bool cameraEffects;

	public static Action<bool> OnMuteChange;

	public static Action<bool> OnCameraEffectsChange;

	public static Action OnCameraSettingAdded;

	public static Action<bool> OnCameraCubeAddedRemoved;

	public static Action<bool> OnGameCameraEffectsChange;

	private int cullingMask;

	private MaskMode maskMode;

	public Skybox Skybox => null;

	public LineDrawManager LineDrawManager => null;

	public float FieldOfView
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Camera MainCamera => null;

	public MVCameraBase CurrentCamera => null;

	public bool BlueModeEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ProtectedTransform ProtectedTransform => null;

	public Vector3 FireDirection => default;

	public Vector3 FireOrigin => default;

	public static bool Mute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool GameHasCameraEffects
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CameraEffects
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MaskMode CamMaskMode
	{
		get
		{
			return MaskMode.Default;
		}
		set
		{
		}
	}

	public bool TertiaryCameraActive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Camera TertiaryCamera => null;

	public Camera SecondaryCamera => null;

	public bool IsLogicRendered
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event EventHandler<OnIgnoreInputTypesArgs> onIgnoreInputTypes
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void EnableScreenOptimizer()
	{
	}

	public static void RegisterCameraWithSettings(MVGameType gameType, ICameraSettings camSettings)
	{
	}

	public static void UnRegisterCameraWithSettings(MVGameType gameType)
	{
	}

	public static ICameraSettings GetSettings(MVGameType gameType)
	{
		return null;
	}

	public static bool HasSetting(MVGameType gameType)
	{
		return false;
	}

	public void PlayPlingSound()
	{
	}

	public void SetCameraController(MVCameraController camController)
	{
	}

	public bool IsCameraControllerSet()
	{
		return false;
	}

	protected void Awake()
	{
	}

	public void IgnoreInputTypes(IgnoreInputTypes inputTypes)
	{
	}

	public void Init()
	{
	}

	public void UpdateCamera()
	{
	}

	public void StartTransitionCam(float transitionTime = 2f, bool soft = false)
	{
	}

	public void CancelTransitionCam()
	{
	}

	private void RenderLogic(bool renderLogic)
	{
	}

	protected void OnDestroy()
	{
	}

	private void HandleCameraCubeAddedRemoved(bool cubeAddedRemoved)
	{
	}

	public bool ApplyPostProcessingThis(PostProcessingSettings data)
	{
		return false;
	}

	public static bool ApplyPostProcessing(PostProcessLayer ppLayer, PostProcessVolume ppVolume, PostProcessingSettings data)
	{
		return false;
	}

	private static bool DoPostProcessingColor(PostProcessLayer ppLayer, PostProcessVolume ppVolume, PostProcessingColorSettings colorSettings)
	{
		return false;
	}

	private static bool DoPostProcessingBloom(PostProcessLayer ppLayer, PostProcessVolume ppVolume, PostProcessingBloomSettings bloomSettings)
	{
		return false;
	}

	private static bool DoPostProcessingAmbientOcclusion(PostProcessLayer ppLayer, PostProcessVolume ppVolume, PostProcessingAmbientOcclusionSettings aoSettings)
	{
		return false;
	}

	private static bool DoPostProcessingDepthOfField(PostProcessLayer ppLayer, PostProcessVolume ppVolume, PostProcessingDepthOfFieldSettings aoSettings)
	{
		return false;
	}

	private static bool DoPostProcessingVignette(PostProcessLayer ppLayer, PostProcessVolume ppVolume, PostProcessingVignetteSettings vignetteSettings)
	{
		return false;
	}

	private static bool DoPostProcessingGrain(PostProcessLayer ppLayer, PostProcessVolume ppVolume, PostProcessingGrainSettings grainSettings)
	{
		return false;
	}

	private static bool DoPostProcessingLensDistortion(PostProcessLayer ppLayer, PostProcessVolume ppVolume, PostProcessingLensDistortionSettings lensDistortionSettings)
	{
		return false;
	}

	private static void EnablePostProcessing(PostProcessLayer ppLayer, PostProcessVolume ppVolume, bool ppEnabled)
	{
	}
}
