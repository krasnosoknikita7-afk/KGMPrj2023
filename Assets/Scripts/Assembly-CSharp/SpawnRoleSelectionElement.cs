using Assets.Scripts.AdIntegration;
using MV.Common;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SpawnRoleSelectionElement : DefaultSpawnRoleSelectionElement
{
	[SerializeField]
	private Text spawnRoleCostAmount;

	[SerializeField]
	private GameObject spawnRoleCostObject;

	[SerializeField]
	private NotificationFade spawnRoleCostFader;

	[SerializeField]
	private GameObject moreInfoButton;

	[SerializeField]
	private NotificationFade moreInfoButtonFader;

	[SerializeField]
	private NotificationFade playButtonFader;

	[SerializeField]
	private GameObject playButton;

	[SerializeField]
	private GameObject freeTryButton;

	[SerializeField]
	private GameObject lockedButton;

	[SerializeField]
	private ContinueButtonHandler continueButtonHandler;

	[SerializeField]
	private GamePassesTextBubble lockedTierBubble;

	[SerializeField]
	private SpawnRoleSelectionSkillMenu skillMenuPrefab;

	[SerializeField]
	private SpawnRoleUnlockedPopupController spawnRoleUnlockPopupPrefab;

	[SerializeField]
	private GameObject backgroundTier1;

	[SerializeField]
	private GameObject backgroundTier2;

	[SerializeField]
	private GameObject backgroundTier3;

	[SerializeField]
	private Image tryFreeButtonIcon;

	private GamePassTier tierRequirement;

	private MVTeam teamRequirement;

	private bool awaitingSpawn;

	private bool isWaitingForFreeTryTier;

	private bool haveShownFreeTryUnlock;

	private bool isSubscriber;

	public override GamePassTier Tier => GamePassTier.Tier0;

	private void ChangeBackground(GamePassTier tier)
	{
	}

	public override void Initialize(int spawnRoleIndex, int woId, GamePassTier tierRequirement, MVTeam team, UnityAction<int> onSelectedCallback, UnityAction<int> onActivatedCallback)
	{
	}

	public void ShowSkillMenu()
	{
	}

	public void OnShowSkillMenu()
	{
	}

	public override void UpdateButtonUI()
	{
	}

	public void OnPressPlay()
	{
	}

	public void OnPressFreePlayAd()
	{
	}

	public void OnPressFreePlaySubscriber()
	{
	}

	public void OnPressLockedPlay()
	{
	}

	private int CalculateTotalSpawnRoleCost(int spawnRoleId)
	{
		return 0;
	}

	private void HandlePlayButtonVisibility()
	{
	}

	private bool CanShowFreeTry()
	{
		return false;
	}

	private void HandleTeamSwitching()
	{
	}

	private void StartPlaying()
	{
	}

	private void Close(int spawnRoleID = 0)
	{
	}

	private void AwaitSpawnThenClose()
	{
	}

	private void ShowAd()
	{
	}

	private void RewardedAdCallback(RewardedAdResult result)
	{
	}

	private void PreviewTier()
	{
	}

	private void OnPlayerPlanetDataUpdated()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void OnSelctionHighlight()
	{
	}

	public override void OnSelected()
	{
	}

	public override void OnUnSelected()
	{
	}
}
