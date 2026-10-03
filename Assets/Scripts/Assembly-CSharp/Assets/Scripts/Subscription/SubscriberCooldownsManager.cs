using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Subscription
{
	public class SubscriberCooldownsManager : MonoBehaviour
	{
		private struct Cooldown
		{
			public float LastUseTime;
		}

		private static readonly int nrOfCooldownTypes;

		private static readonly Dictionary<CooldownType, float> cooldownTimes;

		private readonly Cooldown[] cooldowns;

		private void Awake()
		{
		}

		public void Use(CooldownType type)
		{
		}

		public float CooldownTimeLeft(CooldownType type)
		{
			return 0f;
		}

		public bool IsInCooldown(CooldownType type)
		{
			return false;
		}

		public float CooldownFraction(CooldownType type)
		{
			return 0f;
		}
	}
}
