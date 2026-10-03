using MV.WorldObject;
using UnityEngine;

public abstract class WinningConditionBase : MonoBehaviour
{
	[SerializeField]
	private RoundTimer roundTimerPrefab;

	private RoundTimer roundTimer;

	protected abstract GameStatCounterType StatType { get; }

	public virtual bool WinningConditionAbleToBeFulfilled => false;

	public abstract void UpdateValue(int newValue);

	public void UpdateStats(int actorNumber, GameStatCounterType counterType, int scoreCount)
	{
	}

	protected void UpdateProgressNotification(int actorNumber, GameStatCounterType counterType, int scoreCount)
	{
	}

	public virtual bool CanWinningConditionBeFullfilledForTeam(MVTeam team)
	{
		return false;
	}

	public virtual void Clear()
	{
	}

	public virtual void RoundEndReset()
	{
	}

	public virtual void InitializeGameUI(RectTransform lobbyState)
	{
	}

	private void CreateRoundTimer(WorldObjectClientRef<MVRoundCube> roundCube)
	{
	}
}
