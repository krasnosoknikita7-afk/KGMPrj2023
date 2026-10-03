using MV.Common;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRoleUnlockedPopupController : MonoBehaviour
{
	[SerializeField]
	private Image Background;

	[SerializeField]
	private Text titleText;

	[SerializeField]
	private RectTransform spawnRoleContentTransform;

	[SerializeField]
	private RawImage spawnRolePreviewImage;

	[SerializeField]
	private ContinueButtonHandler continueButtonHandler;

	[SerializeField]
	private ContinueButtonHandler backgroundContinueButtonHandler;

	[SerializeField]
	private SpawnRolePreviewer spawnRolePreviewPrefab;

	[SerializeField]
	private TierUnlockedPopupController TierUnlockedPopupControllerPrefab;

	[SerializeField]
	protected int previewWidth;

	[SerializeField]
	protected int previewHeight;

	[SerializeField]
	private float bounceEffectDuration;

	[SerializeField]
	private AnimationCurve bounceEffect;

	private SpawnRolePreviewer spawnRolePreviewer;

	private GamePassTier unlockedTier;

	private bool wasPurchased;

	private bool wasTempUnlocked;

	private int spawnRoleWoId;

	private MVTeam team;

	private float bounceEffectStartTime;

	private bool awaitingSpawn;

	public void Initialize(GamePassTier unlockedTier, bool wasPurchased, bool wasTempUnlocked, int spawnRoleWoId)
	{
	}

	public void OnPressedPlay()
	{
	}

	public void SeeTierReward()
	{
	}

	private void SetupPreviewImage(GameObject spawnRolePreviewObject)
	{
	}

	private void SetupColor(MVTeam spawnRoleTeam)
	{
	}

	private Color GetColor(MVTeam spawnRoleTeam)
	{
		return default;
	}

	private void StartEffect()
	{
	}

	private void HandleTeamSwitching()
	{
	}

	private void Close(int spawnRoleID = 0)
	{
	}

	private void AwaitSpawnThenClose()
	{
	}

	private void StartPlaying()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
