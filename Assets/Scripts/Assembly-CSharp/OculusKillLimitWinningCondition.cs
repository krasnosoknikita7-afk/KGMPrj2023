using UnityEngine;
using UnityEngine.UI;

public class OculusKillLimitWinningCondition : WinningConditionBase
{
	[SerializeField]
	private Image killImage;

	[SerializeField]
	private Text progress;

	[SerializeField]
	private ProgressBar progressBar;

	private int oculusKillLimit;

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
