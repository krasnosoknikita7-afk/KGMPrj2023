using MV.WorldObject;
using UnityEngine.Events;

public static class DataUploadManager
{
	private const int chunkSize = 5000;

	private static int id;

	private static BytePacker bytePacker;

	private static UnityAction doneNotification;

	public static void UploadData(byte[] data, UnityAction doneNotification)
	{
	}

	public static void OnUploadBytes()
	{
	}

	public static void Reset()
	{
	}

	private static void SendChunk()
	{
	}

	private static void HandleDone()
	{
	}
}
