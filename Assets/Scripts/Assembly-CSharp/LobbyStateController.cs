using UnityEngine;

public class LobbyStateController : LobbyFlowMenu
{
	[SerializeField]
	private GameObject touristRegisterButton;

	[SerializeField]
	private GameObject accessoryShop;

	[SerializeField]
	private LobbyStateButton lobbyStatePlayButton;

	[SerializeField]
	private LobbyStateButton playButton;

	[SerializeField]
	private GameObject goldIconOnPlayButton;

	[SerializeField]
	private GamePassesUI gamePassesUIPrefab;

	[SerializeField]
	private GameObject startGoldRewardPopupPrefab;

	[SerializeField]
	private BoostMenuController boosterMenu;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

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

	private void OnEnable()
	{
	}

	private void EnableGoldReward()
	{
	}
}
