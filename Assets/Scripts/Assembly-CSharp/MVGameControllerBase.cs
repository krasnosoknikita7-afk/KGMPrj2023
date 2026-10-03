using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AntiHack;
using Assets.Scripts.AdIntegration;
using Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.Mediator;
using Assets.Scripts.Subscription;
using MV.Common;
using UnityEngine;
using UnityEngine.Networking;

public abstract class MVGameControllerBase : MonoBehaviour, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	public delegate void OnReceivedGameMsgDelegate(MVGameMsgType type, Dictionary<object, object> gameMsgData);

	public delegate void OnReceivedNotificationEventDelegate(NotificationType type, Dictionary<object, object> data);

	public delegate void OnPostGameInitDelegate();

	protected class VersionData
	{
		public int minVersion { get; set; }

		public int version { get; set; }

		public bool ForceUpdate(int clientVersion)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}

	public const bool LevelingTestMode = false;

	public const bool ClientShopInsideInventory = true;

	[SerializeField]
	protected RegionConfigManager regionConfigManager;

	[SerializeField]
	protected DebugLogHandler debugLogHandler;

	[SerializeField]
	protected KoGaMaSettingsContainer koGaMaSettings;

	[SerializeField]
	private MainCameraManager mainCameraManager;

	[SerializeField]
	private Styles styles;

	[SerializeField]
	private MaterialLoader materialLoader;

	[SerializeField]
	protected PrefabPool prefabPool;

	[SerializeField]
	protected TextureIntegrityChecker textureIntegrityChecker;

	[SerializeField]
	private ThemeRepository themeRepository;

	[SerializeField]
	private StreamingAssetManager streamingAssetManager;

	[SerializeField]
	protected EmbeddedPlayerConfig embeddedPlayerConfig;

	public static OnReceivedGameMsgDelegate OnReceivedGameMsg;

	public static OnReceivedNotificationEventDelegate OnReceivedNotification;

	public static OnPostGameInitDelegate OnPostGameInit;

	protected static MVGameControllerBase instance;

	protected MVNetworkGame game;

	private AudioManager audioManager;

	private BrowserComm browserComm;

	private LevelLoader levelLoader;

	private SkinnedMeshOptimizeManager skinnedMeshOptimizeManager;

	private FlagDebriefingControl flagDebriefingControl;

	private GoldRewardManager goldRewardManager;

	protected JoystickControllerStack joystickControllerStack;

	private bool quitHasBeenCalled;

	private TimeReward timeReward;

	private OverrideMaterials overrideMaterials;

	private LoadStats loadStats;

	private MVJoinState _joinState;

	private FirstFrameUpdateActorReady firstFrameUpdateActorReady;

	private int reAuthTestTries;

	protected ModeControllerBase modeController;

	private Action<MVJoinState> onJoinStateChanged;

	[SerializeField]
	private AudioBuild audioBuild;

	[SerializeField]
	private WaterPlaneManager waterPlaneManagerPrefab;

	private WaterPlaneManager waterPlaneManager;

	[SerializeField]
	private SkyboxManager skyboxManager;

	[SerializeField]
	private SubscriberCooldownsManager subscriberCooldownsManager;

	public static SpawnRoleDataMediator SpawnRoleDataMediatorLocal => null;

	public static MVLocalPlayer LocalPlayer => null;

	public static GameEventManager GameEventManager => null;

	public static bool IsInitialized { get; protected set; }

	public static bool DisconnectIsOk { get; private set; }

	public static IPlayModeUI PlayModeUI { get; protected set; }

	public static IEditModeUI EditModeUI { get; protected set; }

	public static bool IsAlive => false;

	public static MVNetworkGame Game => null;

	public static AudioManager AudioManager => null;

	public static BrowserComm BrowserComm => null;

	public static LevelLoader LevelLoader => null;

	public static SkinnedMeshOptimizeManager SkinnedMeshOptimizeManager => null;

	public static FlagDebriefingControl FlagDebriefingControl => null;

	public static GoldRewardManager GoldRewardManager => null;

	public static TextureIntegrityChecker TextureIntegrityChecker => null;

	public static StreamingAssetManager StreamingAssetManager => null;

	protected EmbeddedPlayerConfig EmbeddedPlayerConfig => null;

	protected RegionConfig RegionConfig => null;

	public static StaticAssetsConfig StaticAssetsConfig => default;

	public static bool WebPlayAsTouch { get; set; }

	public static bool WebPlayAsTouchInitialized { get; set; }

	public static GameSessionData GameSessionData { get; private set; }

	public static BuildTarget BuildTarget => (BuildTarget)0;

	public static Action OnFirstFrameUpdateActorReady
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static bool OkToReAuth => false;

	public static int ReAuthTries => 0;

	public static bool UsingDevSessionData => false;

	public static MVNetworkGame.OperationRequests OperationRequests => null;

	public static LoadStats LoadStats => null;

	public static MVGameMode GameMode => MVGameMode.Edit;

	public static MVWorldObjectClientManager WOCM => null;

	public static TimeReward TimeReward => null;

	public static KoGaMaSettingsContainer KoGaMaSettings => null;

	public static bool IsTouristSession => false;

	public static IAdManager AdManager => null;

	protected abstract IAdManager GetAdManager { get; }

	public static bool SeekAdConsent { get; set; }

	public static MVJoinState JoinState
	{
		get
		{
			return MVJoinState.None;
		}
		set
		{
		}
	}

	public static Action<MVJoinState> OnJoinStateChanged
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected abstract bool IsPlayingInternal { get; }

	public static bool IsPlaying => false;

	public static MaterialLoader MaterialLoader => null;

	public static MainCameraManager MainCameraManager => null;

	public static WaterPlaneManager WaterPlaneManager => null;

	public static SkyboxManager SkyboxManager => null;

	public static SubscriberCooldownsManager SubscriberCooldownsManager => null;

	public static bool Quitting { get; private set; }

	public static bool LeavingEditPlayMode { get; set; }

	public static bool IsInCorrectInventory(bool insidePlayerInventory)
	{
		return false;
	}

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public static void UnregisterPlayModeController()
	{
	}

	protected void Update()
	{
	}

	protected void FixedUpdate()
	{
	}

	protected virtual void LateUpdate()
	{
	}

	protected void OnDrawGizmos()
	{
	}

	public static void RegisterPlayModeController(ModeControllerBase playModeController)
	{
	}

	public static void PostGameMsg(MVGameMsgType gameMsgType, Dictionary<object, object> gameMsgData)
	{
	}

	public static void PostGameMsg(MVGameMsgType gameMsgType, string message)
	{
	}

	public static void PostDestroyCleanup()
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public static void RegisterJoystickControllerStack(JoystickControllerStack joystickControllerStack)
	{
	}

	public static void PushJoystick(ControlType joystickType)
	{
	}

	public static void PopJoystick()
	{
	}

	public static void SetGameSessionData(GameSessionData gameSessionData)
	{
	}

	public static bool TryReauth()
	{
		return false;
	}

	public static void ApplicationQuit(QuitBaseCallback applicationQuitObject)
	{
	}

	public static void RegisterOverrideMaterials()
	{
	}

	[PreserveSig]
	private static extern bool SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

	[PreserveSig]
	public static extern IntPtr FindWindow(string className, string windowName);

	public static void SetPosition(int x, int y, int resX = 0, int resY = 0)
	{
	}

	protected void OnApplicationQuit()
	{
	}

	protected void ShutDown()
	{
	}

	protected abstract void HandleApplicationQuit(QuitBaseCallback quitBaseCallback);

	protected virtual void CleanUp()
	{
	}

	protected void HandleQuitDisconnect()
	{
	}

	private void AlternatePortTest()
	{
	}

	protected virtual void StartGame()
	{
	}

	protected virtual void InitWebGL(bool developmentMode)
	{
	}

	protected virtual void InitStandAlone(bool developmentMode)
	{
	}

	protected void OnReceivedReAuthWebParametersFromHttpRequest(UnityWebRequest www)
	{
	}

	protected void OnReceivedSessionData(UnityWebRequest www)
	{
	}

	protected virtual void UpdateInternal()
	{
	}

	protected void Initialize()
	{
	}

	private void HandleDebugShortCuts()
	{
	}

	private void StartGameWithSessionData(bool ok, string sessionDataJson)
	{
	}

	private void ReceivedLoadStatsCallback(bool ok, string data)
	{
	}

	private void UpdateGame()
	{
	}

	protected static void DeleteScreenPlayerPrefs()
	{
	}

	public void UpdateControllerLateUpdate()
	{
	}

	public static void ForceEmbedSite(string url)
	{
	}
}
