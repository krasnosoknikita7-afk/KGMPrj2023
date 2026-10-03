public class WaitForTicksLocal
{
	public readonly int startTicks;

	private readonly uint maxTicks;

	public bool TimeIsUp => false;

	public WaitForTicksLocal(int milliseconds)
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
