using UnityEngine;

public class GameMeterHealth : GameMeterBase
{
	[SerializeField]
	private GameObject HealthMeter;

	[SerializeField]
	private ProgressBar progressBar;

	private int maxValue;

	public override GameMeterType GameMeterType => GameMeterType.Kills;

	public override void SetGameMeterVisibility()
	{
	}

	public override void UpdateValue()
	{
	}

	public override void SetShowGameMeter(bool show)
	{
	}

	public override void Initialize()
	{
	}

	private void OnMaxValueUpdate(int maxValue)
	{
	}

	private void OnProgressUpdate(float newValue)
	{
	}
}
