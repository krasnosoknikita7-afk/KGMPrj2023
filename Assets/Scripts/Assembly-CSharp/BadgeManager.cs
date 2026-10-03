using System;
using System.Collections.Generic;
using UnityEngine.Networking;

public static class BadgeManager
{
	public const int defaultMaxFriendsLimit = 200;

	private static Dictionary<int, BadgeUrlData> badgeUrls;

	private static int maxLevelBadge;

	private const string fromUnityArgument = "?Unity=2";

	public static void Initialize(List<BadgeUrlData> badgeUrlDatas)
	{
	}

	public static int GetFriendsLimit(int level)
	{
		return 0;
	}

	public static void UnsubscribeGetBadgeRequest(Action<UnityWebRequest> callback)
	{
	}

	public static void GetBadgeTexture(int level, Action<UnityWebRequest> callback)
	{
	}

	public static void Reset()
	{
	}
}
