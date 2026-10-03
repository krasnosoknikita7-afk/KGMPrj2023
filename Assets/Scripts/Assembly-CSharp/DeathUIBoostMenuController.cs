using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class DeathUIBoostMenuController : MonoBehaviour
{
	[SerializeField]
	private Image timerFill;

	[SerializeField]
	private Text restartText;

	[SerializeField]
	private NotificationFade fader;

	[SerializeField]
	private NotificationFade buttonFader;

	[SerializeField]
	private NotificationFade resetButtonFader;

	[SerializeField]
	private NotificationFade boostFader;

	[SerializeField]
	private NotificationFade menuButtonFader;

	[SerializeField]
	private Image readyToPlayTimerFill;

	[SerializeField]
	private GameObject readyToPlayTimerObject;

	[SerializeField]
	private PointerDownController respawnButton;

	[SerializeField]
	private PointerDownController resetButton;

	[SerializeField]
	private BoostMenuController boostMenu;

	[SerializeField]
	private ContinueTierBoostPopup continueTierBoostPopupPrefab;

	[SerializeField]
	private ContinueButtonLockCursor continueButtonLockCursor;

	[SerializeField]
	private Image adIcon;

	[SerializeField]
	private Image playIcon;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private float startTime;

	private readonly float timeUntilGhostMode;

	private bool shouldPop;

	private bool wantsToPlay;

	private bool isGhost;

	public void Initialize()
	{
	}

	public void OpenMenu()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnResetToSpawnPoint()
	{
	}

	private void OnRespawn()
	{
	}

	private void ReadyToSpawn(bool promotionPushedToStack, bool withAd)
	{
	}

	private void LockCursorAndPop()
	{
	}

	private void OnAvatarStateChanged(SpawnRoleModeType mode)
	{
	}
}
