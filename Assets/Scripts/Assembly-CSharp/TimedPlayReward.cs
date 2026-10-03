using System;
using UnityEngine;
using UnityEngine.Networking;

public class TimedPlayReward : RewardButtonBase, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	public static class RewardTracker
	{
		public static bool IsCollected;

		public static Action CollectedChanged;

		public static void Reset()
		{
		}

		public static void PostResetCleanup()
		{
		}
	}

	private class RewardData
	{
		public bool rewardEnabled;

		public int timeInSeconds;

		public int xp;

		public override string ToString()
		{
			return null;
		}
	}

	private WaitForTicks waitForTicks;

	[SerializeField]
	private int timeInSeconds;

	public bool RewardAvailable { get; private set; }

	private int RewardXP { get; set; }

	public bool IsClaimable { get; private set; }

	public void Initialize()
	{
	}

	private void RequestRewardPermission()
	{
	}

	private void OnCollectedChanged()
	{
	}

	public void ClaimReward()
	{
	}

	private void OnFinishedViewingAd()
	{
	}

	private void OnFinishedRewardCollecting(UnityWebRequest www)
	{
	}

	private void OnRewardData(UnityWebRequest www)
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	private void OnDestroy()
	{
	}
}
