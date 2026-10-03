using System.Collections.Generic;
using Assets.Scripts.AdIntegration;
using UnityEngine.Events;

namespace WorldObjectTypes.Avatar.Local
{
	public class WorldObjectUseRequirementTracker : Dictionary<int, float>
	{
		private UnityAction<bool> onAdFinishedCallback;

		private readonly Dictionary<UseRequirementType, float> timeouts;

		public bool HasUnlocked(int worldObjectID)
		{
			return false;
		}

		public void PayUse(UseRequirementType requirementType, int worldObjectID, UnityAction<bool> onAdFinished)
		{
		}

		public void UseRequirementFulfilled(UseRequirementType requirementType, int worldObjectID)
		{
		}

		private void RewardedAdCallback(RewardedAdResult obj)
		{
		}
	}
}
