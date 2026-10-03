using System;

public class SpawnStateWrapper : IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	public struct SpawnStateConfiguration
	{
		public int respawnInterval;

		public int respawnCount;
	}

	private SpawnState prevSpawnState;

	private int takenTime;

	private int respawnInterval;

	private int respawnCount;

	private int takenCounter;

	private readonly Action<SpawnState> stateChangeCallback;

	public SpawnState SpawnState { get; private set; }

	public int TakenTime
	{
		set
		{
		}
	}

	public SpawnStateWrapper(int respawnInterval, int respawnCount, int takenTime, Action<SpawnState> stateChangeCallback)
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	public void Destroy()
	{
	}

	public void UpdateConfiguration(SpawnStateConfiguration spawnStateConfiguration)
	{
	}
}
