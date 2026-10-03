using System.Diagnostics;
using MV.Common;

public static class CheatHandling
{
	public static void Init()
	{
	}

	[Conditional("UNITY_STANDALONE_WIN")]
	public static void MachineBanDetected()
	{
	}

	public static void CheatSoftwareRunningDetected()
	{
	}

	public static void TextureHackDetected()
	{
	}

	private static void SpeedHackDetected()
	{
	}

	private static void ObscuredCheatingDetected()
	{
	}

	private static void ExecuteBan(CheatType cheatType)
	{
	}
}
