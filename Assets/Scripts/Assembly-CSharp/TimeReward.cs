using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

public class TimeReward : IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	private abstract class RewardStateBase
	{
		protected RewardStateDataEventArgs rewardStateEventArgs;

		public RewardStateDataEventArgs RewardStateEventArgs => null;

		public abstract RewardStateBase Update();

		public abstract void Destroy();
	}

	private class RequestRewardData : RewardStateBase
	{
		private enum RequestRewardDataStatus
		{
			Requested = 0,
			Accepted = 1,
			Denied = 2
		}

		private class RewardData
		{
			public bool rewardEnabled;

			public int timeInSeconds;

			public int gold;

			public override string ToString()
			{
				return null;
			}
		}

		private RequestRewardDataStatus requestedRewardDataStatus;

		private RewardCountdown rewardCountdown;

		private bool testRewardEnabled;

		private void TestExternalCallBack(string function, Action<Dictionary<string, object>> action)
		{
		}

		public override RewardStateBase Update()
		{
			return null;
		}

		private void OnRewardData(UnityWebRequest www)
		{
		}

		public override void Destroy()
		{
		}
	}

	private class RewardCountdown : RewardStateBase
	{
		private WaitForTicks waitForTicks;

		public RewardCountdown(int timeInSeconds, int amountGold)
		{
		}

		public override void Destroy()
		{
		}

		public override RewardStateBase Update()
		{
			return null;
		}
	}

	private class RequestReward : RewardStateBase
	{
		public override void Destroy()
		{
		}

		public override RewardStateBase Update()
		{
			return null;
		}
	}

	private class RewardDone : RewardStateBase
	{
		public override void Destroy()
		{
		}

		public override RewardStateBase Update()
		{
			return null;
		}
	}

	private RewardStateBase rewardStateBase;

	[CompilerGenerated]
	private EventHandler<RewardStateDataEventArgs> m_RewardStateChanged;

	public event EventHandler<RewardStateDataEventArgs> RewardStateChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Init()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void DestroyRewardRequest()
	{
	}
}
