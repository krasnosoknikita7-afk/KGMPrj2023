using System;
using Assets.Scripts.AdIntegration;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LobbyStateButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private TeamMenu teamMenuPrefab;

	[SerializeField]
	private WinningConditionBriefing winningConditionBriefingMenu;

	[SerializeField]
	private SpawnRoleMenu spawnRoleMenuPrefab;

	[SerializeField]
	private Image countdownFill;

	[SerializeField]
	private Button lobbyStateButton;

	[SerializeField]
	private LevelRewardsLobbyState levelRewards;

	[SerializeField]
	private ContinueButtonLockCursor continueScreenPrefab;

	[SerializeField]
	private Image playButtonImage;

	[SerializeField]
	private Sprite watchAdPlayButtonImageSprite;

	[SerializeField]
	private Sprite playButtonImageSprite;

	[SerializeField]
	private GamePassesTextBubble signupToRemoveAds;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private bool shouldUpdateFillImage;

	private bool isMoveOverButton;

	private bool showingAdSprite;

	private bool shouldPop;

	private bool isInAd;

	public bool ShouldPop
	{
		set
		{
		}
	}

	private bool IsRoundEnded => false;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPressPlay()
	{
	}

	private void RequestAdWithCallback(Action<InterstitialAdResult> callback)
	{
	}

	private void OnShowAdFinishedSpawnRolesPresent(InterstitialAdResult result)
	{
	}

	private void OnShowAdFinishedEnterPlaymode(InterstitialAdResult result)
	{
	}

	private void PopThenLockCursor()
	{
	}

	private void DoLockCursor()
	{
	}

	public void CancelEnterPlay()
	{
	}

	private void OnCountDownEnd()
	{
	}

	private void StartPlaying()
	{
	}

	private void LockCursor()
	{
	}

	private void OnEnable()
	{
	}

	private void CreateTeamMenu()
	{
	}

	private void CreateSpawnRoleSelectionMenu()
	{
	}

	private void CreateBriefing(WinningConditionType winCon)
	{
	}
}
