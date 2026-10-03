using UnityEngine;
using UnityEngine.UI;

public class GameMeterGameCoin : GameMeterBase
{
	[SerializeField]
	private Image gameCoinBar;

	[SerializeField]
	private GameObject coinAmount;

	[SerializeField]
	private RollingNumberCounterAndroid counter;

	[SerializeField]
	private bool useText;

	[SerializeField]
	private Text counterText;

	public override GameMeterType GameMeterType => GameMeterType.Kills;

	public override void Initialize()
	{
	}

	public override void SetGameMeterVisibility()
	{
	}

	private void OnGameCoinAmountChanged(int amount)
	{
	}

	private void OnDestroy()
	{
	}

	public void OnActivationChange(bool wantToShow)
	{
	}

	public override void UpdateValue()
	{
	}

	public override void SetShowGameMeter(bool show)
	{
	}

	private void Show()
	{
	}

	private void Hide()
	{
	}
}
