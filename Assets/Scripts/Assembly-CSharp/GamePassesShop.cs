using System.Collections.Generic;
using Assets.Scripts.AdIntegration;
using MV.Common;
using MV.WorldObject;
using MV.WorldObject.GamePassSystem;
using UnityEngine;
using UnityEngine.UI;

public class GamePassesShop : MonoBehaviour
{
	[SerializeField]
	private Text headerText;

	[SerializeField]
	private Text progressHeader;

	[SerializeField]
	private Text progressText;

	[SerializeField]
	private ProgressBar progressBar;

	[SerializeField]
	private ProgressBar endResultProgressBar;

	[SerializeField]
	private ProgressBar disabledProgressBar;

	[SerializeField]
	private GameObject progressBarDivider;

	[SerializeField]
	private Text gameTierIconText;

	[SerializeField]
	private GameObject unlockedText;

	[SerializeField]
	private RectTransform tierListContainer;

	[SerializeField]
	private RectTransform tierList;

	[SerializeField]
	private SpawnPointInfo spawnPointInfoPrefab;

	[SerializeField]
	private GamePassesXpRewardInfo xpRewardInfoPrefab;

	[SerializeField]
	private TierUnlockedItemsRewardInfo tierUnlockedItemsRewardInfoPrefab;

	[SerializeField]
	private TierUnlockedAccessItemsRewardInfo tierUnlockedAccessItemsRewardInfoPrefab;

	[SerializeField]
	private GamePassesSpawnRoleRewardInfo spawnRoleRewardInfoPrefab;

	[SerializeField]
	private GamePassesPurchaseButton purchaseButton;

	[SerializeField]
	private GameObject purchaseButtonObject;

	[SerializeField]
	private GameObject freeTryUI;

	[SerializeField]
	private Text unlockTimeText;

	[SerializeField]
	private Text unlockPriceText;

	[SerializeField]
	private Text crystalAmount;

	[SerializeField]
	private GameObject editModeInformationObject;

	[SerializeField]
	private GameObject gameTierProgressObject;

	[SerializeField]
	private GameObject statusFooterObject;

	[SerializeField]
	private GamePassesShopContentCuller contentCuller;

	[SerializeField]
	private TierUnlockedPopupController TierUnlockedPopupControllerPrefab;

	[SerializeField]
	private TierPurchasePopup tierPurchasePopupPrefab;

	[SerializeField]
	private TierPurchaseNotEnoughGoldErrorPopup tierPurchaseGoldErrorPopupPrefab;

	[SerializeField]
	private GamePassesTouristInformationPopup touristInformationPopupPrefab;

	[SerializeField]
	private GameObject gamePassesShopInformationPrefab;

	[SerializeField]
	private Image buttonIcon;

	[SerializeField]
	private Image lockedTierIcon;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private GamePassTier gamePassTierDisplayed;

	private float lerpStartTime;

	private int oldGamePointValue;

	private int newGamePointValue;

	private bool shouldLerp;

	private bool isWaitingForFreeTryTier;

	private bool haveShownFreeTryUnlock;

	private bool delayedInit;

	private bool isSubscribed;

	private static bool haveInitializedHighestTierRewardShown;

	public static void UpdateHighestTierRewardShown(GamePassTier newHighestTierRewardShown)
	{
	}

	public void Initialize(GamePassTier gamePassTierToDisplay)
	{
	}

	private void DelayedInitialize()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private TierLockState GetTierLockState(GamePassTier gamePassTierToDisplay)
	{
		return TierLockState.Unlocked;
	}

	private void HandlePurchaseButtonVisibility(GamePassTier gamePassTierToDisplay)
	{
	}

	private void HandleEditModeUI()
	{
	}

	private void Update()
	{
	}

	private void UpdateProgressBar(GamePassTier gamePassTierToDisplay)
	{
	}

	private void ActivateBar()
	{
	}

	private void DeactivateBar()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateTierCostTets()
	{
	}

	private void UpdateFreeTryUI()
	{
	}

	private int ReduceGamePointsWithPreviousTierRequirements(GamePassTier gamePassTierToDisplay, int gamePoints, Dictionary<GamePassTier, PlayerTierState> gameTierShopStatus)
	{
		return 0;
	}

	private void AddTierContent(GamePassTier gamePassTierToDisplay)
	{
	}

	private void CreateSpawnPointInfo(MVTeam team)
	{
	}

	private void CreateXPRewardInfo(GamePassTier tier)
	{
	}

	private void CreateUnlockedItemsInfo(GamePassTier tier, Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> tierShopData)
	{
	}

	private Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> SortOutNonLootItemsInShopData(Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> tierShopData)
	{
		return null;
	}

	private bool IsTierItemALootItem(MVWorldObjectClient item)
	{
		return false;
	}

	private void CreateUnlockedAccessItemsInfo(GamePassTier tier, Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> tierShopData)
	{
	}

	private Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> SortOutNonAccessItemsInShopData(Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> tierShopData)
	{
		return null;
	}

	private bool IsTierItemAnAccessItem(MVWorldObjectDocumentationType worldObjectType, MVWorldObjectClient item)
	{
		return false;
	}

	private void CreateSpawnRoleContent(GamePassTier gamePassTierToDisplay)
	{
	}

	private List<MVAvatarSpawnRoleCreator> GetSortedSpawnRoles(GamePassTier gamePassTierToDisplay)
	{
		return null;
	}

	private int CalculateTotalSpawnRoleCost(MVAvatarSpawnRoleCreator spawnRoleCreator)
	{
		return 0;
	}

	private void CreateSpawnRoleInfo(int spawnRoleIndex, MVAvatarSpawnRoleCreator spawnRole, GamePassTier tier)
	{
	}

	private void ShowTierUnlockedPopup(bool wasPurchased, bool wasTempUnlocked)
	{
	}

	private void ShowTouristInformationPopup()
	{
	}

	private void ShowPurchaseConfirmPopup(int price)
	{
	}

	private void ShowPurchaseGoldErrorPopup()
	{
	}

	private void HandlePurchase()
	{
	}

	private void OnSuccessfulPurchase()
	{
	}

	private void TestTier()
	{
	}

	private bool ShouldShowTierReward(GamePassTier tierToShow)
	{
		return false;
	}

	private bool IsProgressBarEnabled()
	{
		return false;
	}

	private int GetTotalGamePointRequirementForTier(GamePassTier tier)
	{
		return 0;
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

	public void Exit()
	{
	}

	public void OnButtonPress()
	{
	}

	public void OnTestTierPress()
	{
	}

	public void OnClickFreeTryAd()
	{
	}

	public void OnClickFreeTrySubcribed()
	{
	}

	public void ShowGamePassShopInformationPopup()
	{
	}
}
