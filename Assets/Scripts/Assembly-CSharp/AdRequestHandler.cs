using System;

public static class AdRequestHandler
{
	private class Available
	{
		public bool available { get; set; }
	}

	public class ShouldReward
	{
		public bool shouldReward { get; set; }
	}

	private static Action<bool> OnHealthAdAvailableCallback;

	private static Action<bool> OnHealthAdShownCallback;

	private static Action<bool> OnGoldAdAvailableCallback;

	private static Action<bool> OnGoldAdShownCallback;

	public static void GetHealthAdAvailable(Action<bool> OnAdAvailable)
	{
	}

	private static void HealthAdAvailable(bool success, string availableJsonString)
	{
	}

	public static void ShowHealthVideoAd(Action<bool> OnAdShown)
	{
	}

	private static void ShowHealthVideoAdCallback(bool success, string showVideoJsonString)
	{
	}

	public static void GetGoldAdAvailable(Action<bool> OnAdAvailable)
	{
	}

	private static void GoldAdAvailable(bool success, string availableJsonString)
	{
	}

	public static void ShowGoldVideoAd(Action<bool> OnAdShown)
	{
	}

	private static void ShowGoldVideoAdCallback(bool success, string showVideoJsonString)
	{
	}
}
