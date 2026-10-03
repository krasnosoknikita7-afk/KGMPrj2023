using UnityEngine;
using UnityEngine.UI;

public class DesktopLobbyStateController : LobbyFlowMenu
{
	[SerializeField]
	private GameObject respawnButton;

	[SerializeField]
	private GameObject avatarAccessoriesButton;

	[SerializeField]
	private GameObject touristRegisterButton;

	[SerializeField]
	private LobbyStateButton playButton;

	[SerializeField]
	private GameObject goldIconOnPlayButton;

	[SerializeField]
	private AdOfferGold adOfferGold;

	[SerializeField]
	private LobbyStateButton lobbyStatePlayButton;

	[SerializeField]
	private GamePassesUI gamePassesUIPrefab;

	[SerializeField]
	private GameObject startGoldRewardPopupPrefab;

	[SerializeField]
	private BoostMenuController boosterMenu;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	[SerializeField]
	private GameObject adminObserveButton;

	[SerializeField]
	private Image lobbyStateBlockingOverlay;

	private GamePassesUI gamePassesUI;

	protected override LobbyFlowMenuType MenuType => LobbyFlowMenuType.LobbyState;

	public override void Start()
	{
	}

	public void SetShouldPopOnExit(bool shouldPop)
	{
	}

	public void ShowBoostMenu()
	{
	}

	public void CreateStartGoldRewardPopup()
	{
	}

	private void Update()
	{
	}

	private void SetCamMaskMode()
	{
	}

	private void EnableGoldReward()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
