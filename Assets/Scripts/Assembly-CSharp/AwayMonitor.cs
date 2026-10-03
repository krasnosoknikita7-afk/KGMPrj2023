using System;
using MV.Common;

public class AwayMonitor
{
	private enum State
	{
		Active = 0,
		IdleAndWarned = 1,
		PendingKick = 2,
		Kicked = 3
	}

	private class IdleKickTimes
	{
		public int warningTimeMinutes;

		public int idleKickTimeMinutes;

		public readonly TimeSpan warningTimeSpan;

		public readonly TimeSpan idleKickTimeSpan;

		public IdleKickTimes(int warnAfterMinutes, int kickAfterMinutes)
		{
		}
	}

	private static AwayMonitor instance;

	private DateTime latestResetAFKTime;

	private readonly TimeSpan awayCheckFrequency;

	private IdleKickTimes idleKickTimes;

	private State state;

	private bool idleKickEnabled;

	private DateTime latestMouseMoveTime;

	private const string mouseX = "Mouse X";

	private const string mouseY = "Mouse Y";

	private const string scroll = "Mouse ScrollWheel";

	private const string platformerLeft = "MoveLeft";

	private const string platformerRight = "MoveRight";

	private static bool allAxisAvailable;

	private static bool allPlatformerButtonsAvailable;

	public static bool IdleKickEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public DateTime LatestMouseMoveTime => default;

	private AwayMonitor()
	{
	}

	public static void Initialize(MVGameMode mode)
	{
	}

	public static void Destroy()
	{
	}

	public static void UpdateMobile()
	{
	}

	public static void BackgroundUpdate()
	{
	}

	public static void InternalUpdate()
	{
	}

	private void UpdateButtons()
	{
	}

	public static void Update()
	{
	}

	public static void UpdateIdleAction()
	{
	}

	private void UpdateIdle()
	{
	}

	private void UpdateMouse()
	{
	}

	private void HandleIdle(bool fromBackgroundUpdate)
	{
	}

	private void CheckAndResolvePendingKick()
	{
	}
}
