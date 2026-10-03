using System;

public class GameMeterKillLimit : GameMeterKillBase
{
	private KillLimitClient killClient;

	private int prevValue;

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
}
