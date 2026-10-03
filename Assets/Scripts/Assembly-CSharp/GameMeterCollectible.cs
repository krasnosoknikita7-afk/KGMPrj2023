using System;
using UnityEngine;
using UnityEngine.UI;

public class GameMeterCollectible : GameMeterBase
{
	[SerializeField]
	private Image collectibleBar;

	[SerializeField]
	private Text collectibleText;

	private int prevValue;

	private AllCollectiblesCollectedClient collectedClient;

	public override GameMeterType GameMeterType => GameMeterType.Kills;

	public override void Initialize()
	{
	}

	private void OnVictoryConditionMet(object sender, EventArgs args)
	{
	}

	private void OnDestroy()
	{
	}

	public override void SetGameMeterVisibility()
	{
	}

	public override void UpdateValue()
	{
	}

	private void Hide()
	{
	}

	private void Show()
	{
	}

	public override void SetShowGameMeter(bool show)
	{
	}
}
