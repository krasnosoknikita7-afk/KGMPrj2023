using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMeterRoundTime : GameMeterBase
{
	[SerializeField]
	private Image roundTimeBar;

	[SerializeField]
	private Text roundTime;

	[SerializeField]
	private GameObject mainGameObject;

	private MVRoundCube roundCube;

	private List<int> timeNotifications;

	public override GameMeterType GameMeterType => GameMeterType.Kills;

	public override void Initialize()
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

	private void Update()
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

	private int GetTimeLeft(MVRoundCube roundCube)
	{
		return 0;
	}

	private void HandleTimeNotifications(int timeLeft)
	{
	}

	private void ResetTimeNotifications()
	{
	}

	private void ResetOnRoundEnd(IWinningCondition winningCondition)
	{
	}
}
