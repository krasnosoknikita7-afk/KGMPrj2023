using Assets.Scripts.AdIntegration;
using MV.Common;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class ContinueTierBoostPopup : MonoBehaviour
{
	[SerializeField]
	private Text tierNumber;

	[SerializeField]
	private Text continueRewardDescriptionText;

	[SerializeField]
	private Text tempClassContinueRewardDescriptionText;

	[SerializeField]
	private GameObject countdownGameObject;

	[SerializeField]
	private Image countdownFillImage;

	[SerializeField]
	private Text countdownText;

	[SerializeField]
	private GameObject defaultUI;

	[SerializeField]
	private GameObject tempClassUI;

	[SerializeField]
	private CurrentSpawnRolePreviewer spawnRolePreviewer;

	[SerializeField]
	private GameObject backgroundTier1;

	[SerializeField]
	private GameObject backgroundTier2;

	[SerializeField]
	private GameObject backgroundTier3;

	[SerializeField]
	private TierUnlockedPopupController TierUnlockedPopupControllerPrefab;

	[SerializeField]
	private SpawnRoleMenu spawnRoleSelectionMenuPrefab;

	[SerializeField]
	private TeamMenu teamMenuPrefab;

	[SerializeField]
	private float countDownDuration;

	[SerializeField]
	private Image buttonIcon;

	private const string rewardDescription = "Keep playing as Tier {0}?";

	private float timeLeft;

	private bool isWaitingForFreeTryTier;

	private bool shouldUpdate;

	private bool isSubscriber;

	private GamePassTier previousPreviewTier;

	public void OnClickWatchAd()
	{
	}

	public void OnClickSubscriber()
	{
	}

	public void OnDeclinePressed()
	{
	}

	public void Initialize(int tier)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ShowTierUnlock(bool wasPurchased, bool wasTempUnlocked)
	{
	}

	private void ShowSpawnRoleSelectionMenu()
	{
	}

	private void ShowTeamSelectionMenu()
	{
	}

	private void ShowAd()
	{
	}

	private void RewardedAdCallback(RewardedAdResult result)
	{
	}

	public void StopPreviewTier()
	{
	}

	private void OnPlayerPlanetDataUpdated()
	{
	}

	private void ExitContinuePopup()
	{
	}

	private bool IsInTempClass()
	{
		return false;
	}

	private bool CanSpawnInTeam(MVTeam team)
	{
		return false;
	}

	private void ChangeBackground(GamePassTier tier)
	{
	}
}
