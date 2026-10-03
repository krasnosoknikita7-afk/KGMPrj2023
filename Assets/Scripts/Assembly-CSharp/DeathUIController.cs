using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class DeathUIController : MonoBehaviour
{
	[SerializeField]
	private Text deathReason;

	[SerializeField]
	private NotificationFade fader;

	[SerializeField]
	private TierUnlockedPopupController tierUnlockedPopupControllerPrefab;

	[SerializeField]
	private DeathUIBoostMenuController boostMenuPrefab;

	[SerializeField]
	private ReviveUIHandler reviveHandler;

	[SerializeField]
	private ReviveUIHandlerBoosts reviveHandlerBoosts;

	[SerializeField]
	private TierOnDeathProgress tierOnDeathProgress;

	[SerializeField]
	private GameObject claimGoldRewardPopupPrefab;

	[SerializeField]
	private TierBoostStateHandler tierHandler;

	[SerializeField]
	private GameObject invisibleBlocker;

	[SerializeField]
	private GameObject deathMessageBar;

	private float waitTime;

	private bool isDeathBriefActive;

	private void Awake()
	{
	}

	private void Initialize()
	{
	}

	private void OnAvatarStateChanged(SpawnRoleModeType mode)
	{
	}

	private void EndDeathBriefing()
	{
	}

	private void Update()
	{
	}

	private void TierProgress()
	{
	}

	private void OnDestroy()
	{
	}

	private void ShowReviveMenu(bool reboostOnly)
	{
	}

	private void ReboostNotClicked()
	{
	}

	private void ReviveNotClicked()
	{
	}

	private void NotReviving()
	{
	}

	private void OnFinishPreviewTier(bool openBoostMenu)
	{
	}

	private void OnDisable()
	{
	}

	private void ShowBoostMenu()
	{
	}

	private void OnFadeFinished()
	{
	}

	private void ShowTierUnlockedPopup(bool wasPurchased, bool wasTempUnlocked)
	{
	}

	private void OnTierUnlockedPop()
	{
	}

	private bool ShowingClaimGold()
	{
		return false;
	}

	private void ShowDeadmodeUI()
	{
	}

	private bool ShouldShowTierReward(GamePassTier tierToShow)
	{
		return false;
	}

	private void OnLocalAvatarSuicide()
	{
	}

	private void OnLocalPlayerKilled(int localPlayerActorNr, int dmgDealerActorNr, PlayerKilledByType damageType)
	{
	}

	private void SendCurrentProgressNotification()
	{
	}

	private void StartDeathBriefing(string deathText)
	{
	}

	private void OnRoundEnd(IWinningCondition winningCondition)
	{
	}

	public void OnPressPlay()
	{
	}
}
