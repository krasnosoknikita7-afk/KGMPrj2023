using Assets.Scripts.AdIntegration;
using MV.Common;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class GamePassesSpawnRoleRewardInfo : MonoBehaviour, IGamePassShopContent
{
	[SerializeField]
	private Image spawnRoleTeamImage;

	[SerializeField]
	private RawImage spawnRoleImage;

	[SerializeField]
	private Text spawnRoleCostAmount;

	[SerializeField]
	private GameObject spawnRoleEditButton;

	[SerializeField]
	private GameObject lockedUI;

	[SerializeField]
	private GameObject unlockedUI;

	[SerializeField]
	private GameObject freeTryUI;

	[SerializeField]
	private ContinueButtonHandler continueButtonHandler;

	[SerializeField]
	private GamePassesTextBubble lockedTipTextBubble;

	[SerializeField]
	private SpawnRoleEditorMenu spawnRoleEditorMenuPrefab;

	[SerializeField]
	private SpawnRolePreviewer spawnRolePreviewerPrefab;

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
	private int previewWidth;

	[SerializeField]
	private int previewHeight;

	[SerializeField]
	private Image buttonAdImage;

	private SpawnRolePreviewer spawnRolePreviewer;

	private int spawnRoleIndex;

	private MVAvatarSpawnRoleCreator spawnRole;

	private int woid;

	private GamePassTier tierRequirment;

	private MVTeam team;

	private GameObject spawnRolePreviewObject;

	private bool awaitingSpawn;

	private bool enterPlayWhenPlayerCanSpawn;

	private bool isWaitingForFreeTryTier;

	private bool haveShownFreeTryUnlock;

	private void OnDestroy()
	{
	}

	public void Initialize(int spawnRoleIndex, GameObject spawnRolePreviewObject, MVAvatarSpawnRoleCreator spawnRole, GamePassTier tierRequirment)
	{
	}

	public void OnPressed()
	{
	}

	public void OnEditPressed()
	{
	}

	public void OnLockedPressed()
	{
	}

	public void OnPressFreePlay()
	{
	}

	public void OnPlayPressed()
	{
	}

	private void AwaitSpawnThenClose()
	{
	}

	private void Close(int spawnRoleID = 0)
	{
	}

	private void HandleTeamSwitching()
	{
	}

	private void StartPlaying()
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	private void Update()
	{
	}

	private Color GetTeamRequirementColor(MVTeam team)
	{
		return default;
	}

	private void ChangeBackground(GamePassTier tier)
	{
	}

	private void SetupPreviewImage(GameObject spawnRolePreviewObject)
	{
	}

	private void OnSpawnRoleBodyUpdate()
	{
	}

	private int CalculateSpawnRoleCost()
	{
		return 0;
	}

	private void HandleLockedUIVisibility(bool playerHasUnlockedTier, bool isTierUnlockable)
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

	private bool CanSpawn()
	{
		return false;
	}

	private bool CanShowFreeTry()
	{
		return false;
	}
}
