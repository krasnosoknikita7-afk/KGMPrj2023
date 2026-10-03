using UnityEngine;
using UnityEngine.UI;

public class GameMeterTimeAttackFlag : GameMeterBase
{
	[SerializeField]
	private Image timeAttackFlagBar;

	[SerializeField]
	private Text timeAttackFlagText;

	private bool shouldUpdate;

	public override GameMeterType GameMeterType => GameMeterType.Kills;

	public override void Initialize()
	{
	}

	private void Update()
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

	private void OnStartFlagCountdown()
	{
	}

	private void OnStartFlagCountdown(int captureTime)
	{
	}

	private void OnEndFlagCountdown()
	{
	}
}
