using UnityEngine;
using UnityEngine.UI;

public class GoldRewardCountdownMeter : MonoBehaviour
{
	[SerializeField]
	private GameObject goldRewardCountdownUI;

	[SerializeField]
	private ProgressBar countdownProgressBar;

	[SerializeField]
	private Text countdownText;

	[SerializeField]
	private GameObject goldRewardClaimableUI;

	[SerializeField]
	private GamePassesTextBubble tipBubble;

	[SerializeField]
	private GameObject claimGoldRewardPopupPrefab;

	private bool isDone;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void UpdateCountdownVisibility()
	{
	}

	private static bool IsGoldRewardCountdownActive()
	{
		return false;
	}

	private void UpdateCountDownProgress()
	{
	}

	private static string GetClaimText()
	{
		return null;
	}

	public void TryShowClaimGoldRewardPopup()
	{
	}
}
