using UnityEngine;
using UnityEngine.UI;

public class GameMeterShield : GameMeterBase
{
	[SerializeField]
	private Image ShieldMeter;

	[SerializeField]
	private ProgressBar progressBar;

	private const float maxShieldValue = 100f;

	private float interpolateTowardsShieldProgress;

	private float previousShieldProgress;

	private float elapsedInterpolationTime;

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

	private void Update()
	{
	}

	private void OnProgressUpdate(float newValue)
	{
	}

	public override void SetShowGameMeter(bool show)
	{
	}
}
