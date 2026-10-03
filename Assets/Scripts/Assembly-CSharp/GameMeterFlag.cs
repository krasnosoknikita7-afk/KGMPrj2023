using UnityEngine;

public class GameMeterFlag : GameMeterBase
{
	[SerializeField]
	private GameObject flagBar;

	private FlagReachedClient flagClient;

	public override GameMeterType GameMeterType => GameMeterType.Kills;

	public override void Initialize()
	{
	}

	public override void SetGameMeterVisibility()
	{
	}

	public override void UpdateValue()
	{
	}

	public override void SetShowGameMeter(bool show)
	{
	}

	private void Hide()
	{
	}

	private void Show()
	{
	}
}
