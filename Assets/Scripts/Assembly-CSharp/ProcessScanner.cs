using System.Runtime.InteropServices;
using MV.WorldObject.AntiCheat;

public static class ProcessScanner
{
	[PreserveSig]
	private static extern void AddToBanList(string certificateSerialNumber, bool strictComparison);

	[PreserveSig]
	private static extern int ScanForForbiddenProcesses();

	[PreserveSig]
	private static extern void Cleanup();

	[PreserveSig]
	public static extern string GetLastExactFind();

	public static void Initialize(ApplicationDesc[] banList)
	{
	}

	public static void Destroy()
	{
	}

	public static void StartScan(ApplicationDesc[] banList)
	{
	}
}
