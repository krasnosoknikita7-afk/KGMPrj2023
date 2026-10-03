using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class DesktopPlayModeController : ModeControllerBase, IPlayModeUI, IActivateUIElement, IEventSystemHandler, ILeaveEditPlayModeHandler, ICanvasController, IAccessoryPopupHandler
{
	private ILockCursorManager lockCursorManager;

	[SerializeField]
	private UIStack uiStack;

	[SerializeField]
	private TeamMenu teamMenu;

	[SerializeField]
	private DesktopInGameGUIController inGameController;

	[SerializeField]
	private RectTransform lobbyState;

	[SerializeField]
	private InGameMenu inGameMenuPrefab;

	[SerializeField]
	private RectTransform playerListButton;

	[SerializeField]
	private RectTransform adminGameMgmtButton;

	[SerializeField]
	private RectTransform notificationsManager;

	[SerializeField]
	private GameObject stackBottom;

	[SerializeField]
	private ChatControllerUGUI chatController;

	[SerializeField]
	private AccessoryShopController accessoryShopController;

	[SerializeField]
	private Canvas canvas;

	[SerializeField]
	private DeathPromotionController deathPromotionController;

	[SerializeField]
	private GameObject fullscreenPlayModeStateTransform;

	[SerializeField]
	private WinningConditionBriefing winningConditionBriefingMenu;

	[SerializeField]
	private LobbyStatePlayModeController lobbyStatePlayModeController;

	[SerializeField]
	private ChatBubbleController chatBubbleController;

	[SerializeField]
	private TimeAttackFlagDebriefing timeAttackFlagDebriefing;

	[SerializeField]
	private GoldPurchasedTracker goldPurchasedTracker;

	[SerializeField]
	private BoostMenuController boosterMenu;

	private RectTransform lobbyStateRect;

	private InGameMenu inGameMenu;

	public UnityAction OnLeaveEditPlayMode;

	private GameObject playModeState;

	public GameObject InGameUIRoot => null;

	public ILockCursorManager LockCursorManager => null;

	public override bool InLobbyState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected void OnDestroy()
	{
	}

	private void HandleInput()
	{
	}

	private void RegisterHotkeys()
	{
	}

	private void Respawn()
	{
	}

	public override void Initialize()
	{
	}

	private void ActivateAdminButton(bool active)
	{
	}

	private void HideUI()
	{
	}

	private void ToggleLogicVisibility()
	{
	}

	private void ToggleHD()
	{
	}

	private void CreateGUI()
	{
	}

	private void OnShowTimeAttackFlagDebriefing(int captureTime)
	{
	}

	private void OnShowTimeAttackFlagCountDown()
	{
	}

	private void OnHideTimeAttackFlagCountDown()
	{
	}

	private void OnRoundEnd(IWinningCondition winningCondition)
	{
	}

	private void LeavePlayMode()
	{
	}

	public override void ShowEUseIcon(ShowUseOption option, int woID = 0)
	{
	}

	public override void HideEUseIcon()
	{
	}

	public override IGUICrossHair GetCrossHair()
	{
		return null;
	}

	public void Activate(ActivateUIElement element)
	{
	}

	public void LeaveEditPlayMode()
	{
	}

	public void SetPixelPerfect(bool pixelPerfect)
	{
	}

	public void SetUIReady()
	{
	}

	public void OpenInventoryAtItem(UIPushOption pushOption, AccessoryDataClient displayShopItems)
	{
	}
}
