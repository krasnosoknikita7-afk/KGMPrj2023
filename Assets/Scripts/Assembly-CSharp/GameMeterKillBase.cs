using UnityEngine;
using UnityEngine.UI;

public class GameMeterKillBase : GameMeterBase
{
	[SerializeField]
	protected Image killsBar;

	[SerializeField]
	protected Text killsText;

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

	protected void SetCount(GameStatCounterType gameStatCounterType, int limit)
	{
	}

	private static int GetCount(GameStatCounterType gameStatCounterType)
	{
		return 0;
	}

	public override void SetShowGameMeter(bool show)
	{
	}

	protected void Hide()
	{
	}

	protected void Show()
	{
	}
}
