public class WaitForTicks
{
	public readonly int startTicks;

	private readonly uint maxTicks;

	public bool TimeIsUp => false;

	public WaitForTicks(int milliseconds)
	{
	}

	public static int GetEnvironmentTick(int deltaMilliseconds)
	{
		return 0;
	}

	public static int Diff(int startTicks)
	{
		return 0;
	}
}
