using UnityEngine;
using UnityEngine.UI;

public class KillLimitWinningCondition : WinningConditionBase
{
	[SerializeField]
	private Image killImage;

	[SerializeField]
	private Text progress;

	[SerializeField]
	private ProgressBar progressBar;

	private int killLimit;

	protected override GameStatCounterType StatType => GameStatCounterType.None;

	public override void InitializeGameUI(RectTransform lobbyState)
	{
	}

	public override void UpdateValue(int newValue)
	{
	}

	public override void RoundEndReset()
	{
	}
}
