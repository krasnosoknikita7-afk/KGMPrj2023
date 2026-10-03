using System;
using UnityEngine.Networking;

internal static class AssetBundleCacheTest
{
	private const string assetUrl = "Test/bignoise.unity3d";

	public static void Run(int version)
	{
	}

	public static void OnFirstDownloadFinished(UnityWebRequest result, float startTime, int currentStreamingAssetVersion)
	{
	}

	public static void OnSecondDownloadFinished(UnityWebRequest result, float startTime, int currentStreamingAssetVersion)
	{
	}

	private static void DownloadTestAsset(Action<UnityWebRequest, float, int> onDownloadFinished, int currentStreamingAssetVersion)
	{
	}
}
