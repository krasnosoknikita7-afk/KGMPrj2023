using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class FlagWinningCondition : WinningConditionBase
{
	[SerializeField]
	private Image flagIcon;

	[SerializeField]
	private GameObject graphics;

	[SerializeField]
	private Text score;

	private const float updateFlagFrequency = 10f;

	protected override GameStatCounterType StatType => GameStatCounterType.None;

	public override bool WinningConditionAbleToBeFulfilled => false;

	public override void InitializeGameUI(RectTransform lobbyState)
	{
	}

	public override void UpdateValue(int newValue)
	{
	}

	public override bool CanWinningConditionBeFullfilledForTeam(MVTeam team)
	{
		return false;
	}

	private void Update()
	{
	}

	private List<MVWorldObjectClient> GetClosestFlags(MVTeam team)
	{
		return null;
	}

	private void UpdateFlagGraphics()
	{
	}

	public override void RoundEndReset()
	{
	}
}
