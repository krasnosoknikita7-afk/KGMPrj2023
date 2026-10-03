using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class TimeAttackFlagDebriefing : MonoBehaviour
{
	[SerializeField]
	private ScoreBoardSingleBase scoreBoardSingle;

	[SerializeField]
	private ScoreBoardTeamBase scoreBoardTeam;

	[SerializeField]
	private LocalPlayerScore localPlayerScore;

	[SerializeField]
	private GameObject sunshineObject;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private CanvasGroup scoreBoardCanvasGroup;

	[SerializeField]
	private Image countdownFill;

	[SerializeField]
	private Button playButton;

	private bool isDebriefingOn;

	private bool isWaitingForStart;

	private bool isExitingDebriefing;

	private bool shouldStartFlagCountdown;

	private float waitStartTime;

	private SpawnRoleModeType previousAvatarModeType;

	private float countdownEndTime;

	private const float waitDuration = 4f;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void Initialize(int captureTime)
	{
	}

	public void InitializeCountDown()
	{
	}

	public void OnPressPlay()
	{
	}

	public void OnLeavePlayMode()
	{
	}

	public void OnRoundEnd()
	{
	}

	private void HandleScoreBoardVisibility(int score)
	{
	}

	private void SendNotification(int captureTime, bool isBestTime)
	{
	}

	private void SendCountDownNotification()
	{
	}

	private string GetDebriefingText(int captureTime, bool isBestTime)
	{
		return null;
	}

	private int GetTopPlayerScore()
	{
		return 0;
	}

	private void OnAvatarStateChanged(SpawnRoleModeType mode)
	{
	}

	private void UpdateButton()
	{
	}

	private void ExitDebriefing()
	{
	}

	private void EndDebriefingEarly()
	{
	}
}
