using System;

public class FlagDebriefingControl
{
	public float RunStartTime;

	public bool IsInFlagDebriefing;

	public Action<int> OnFlagDebriefing;

	public Action OnFlagCountDown;

	public Action OnFlagDebriefingEnd;

	public Action OnFlagCountDownEnd;

	public void StartFlagDebriefing(int captureTime)
	{
	}

	public void StartFlagCountDown()
	{
	}

	public void EndFlagDebriefing()
	{
	}

	public void EndFlagCountDown()
	{
	}

	public void ResetToSpawnPoint()
	{
	}
}
