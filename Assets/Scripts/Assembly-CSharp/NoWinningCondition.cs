using UnityEngine;

public class NoWinningCondition : MonoBehaviour
{
	[SerializeField]
	private RoundTimer roundTimerPrefab;

	private RoundTimer roundTimer;

	public void Initialize(RectTransform lobbyStateUI)
	{
	}

	public void TryInitializeRoundCube()
	{
	}

	public virtual void RoundEndReset()
	{
	}

	public void Clear()
	{
	}

	private void CreateRoundTimer(WorldObjectClientRef<MVRoundCube> roundCube)
	{
	}
}
