using UnityEngine;

public class GameMeterXP : GameMeterBase
{
	[SerializeField]
	private GameObject XPMeter;

	private float interpolateTowardsXPProgress;

	private float previousXPProgress;

	private float elapsedInterpolationTime;

	public override GameMeterType GameMeterType => GameMeterType.Kills;

	public override void Initialize()
	{
	}

	private void Init()
	{
	}

	public override void SetGameMeterVisibility()
	{
	}

	public override void UpdateValue()
	{
	}

	private void Update()
	{
	}

	private void OnProgressUpdate(XPProgressData xpProgress)
	{
	}

	public override void SetShowGameMeter(bool show)
	{
	}
}
