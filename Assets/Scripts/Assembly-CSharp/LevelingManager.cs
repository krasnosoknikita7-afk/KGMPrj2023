using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Networking;

public static class LevelingManager
{
	public static UnityAction OnLevelingInitialized;

	public static readonly Dictionary<int, XPLevelLimits> TestLevelToLimits;

	public static bool IsInitialized { get; private set; }

	public static void Destroy()
	{
	}

	public static void Initialize(int profileID)
	{
	}

	public static void OnInitialData(UnityWebRequest result)
	{
	}

	private static void Notify(InitialLevelData initialLevelData)
	{
	}

	private static InitialLevelData CreateInitialLevelData()
	{
		return null;
	}

	private static List<BadgeUrlData> TestBadgeUrlData()
	{
		return null;
	}
}
