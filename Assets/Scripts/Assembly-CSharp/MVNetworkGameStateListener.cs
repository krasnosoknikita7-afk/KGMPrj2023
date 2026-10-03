using System;
using System.Runtime.CompilerServices;
using MV.Common;

public class MVNetworkGameStateListener
{
	private int startTime;

	private int duration;

	private MVGameStateType currentGameState;

	private int timeLeft;

	[CompilerGenerated]
	private EventHandler<GameStateChangeEventArgs> m_OnGameStateChanged;

	public int TimeLeftMS => 0;

	public int CountdownInSeconds => 0;

	public float CountdownInPercentage => 0f;

	public MVGameStateType CurrentGameState => MVGameStateType.None;

	public int StartTime => 0;

	public event EventHandler<GameStateChangeEventArgs> OnGameStateChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void ChangeState(MVGameStateType gameStateType, int startTime, int duration, bool fromGameSnapshot)
	{
	}

	public void Update(MVNetworkGame game)
	{
	}
}
