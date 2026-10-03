using System.Collections.Generic;
using System.Runtime.InteropServices;
using MV.WorldObject.AntiCheat;

public static class DllProtector
{
	[PreserveSig]
	private static extern uint GetCrcData(byte[] buffer, int len);

	private static int FirstIndexOf(byte[] data, int startIndex, byte val)
	{
		return 0;
	}

	public static List<FileData> GetCRCData()
	{
		return null;
	}

	private static List<FileData> ParseCrcData(byte[] crcData, uint numOfWrittenBytes)
	{
		return null;
	}
}
