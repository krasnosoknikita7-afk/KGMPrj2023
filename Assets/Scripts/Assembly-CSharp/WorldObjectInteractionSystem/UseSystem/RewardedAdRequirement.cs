using System.Collections.Generic;
using UnityEngine;

namespace WorldObjectInteractionSystem.UseSystem
{
	public class RewardedAdRequirement : UseRequirement
	{
		private const UseRequirementType RequirementType = UseRequirementType.RewardedAd;

		private readonly Vector3 displayObjectOffset;

		private int worldObjectID;

		private GameObject displayGO;

		private RewardedAdDisplayObject displayObject;

		private readonly GameObject displayObjectRoot;

		private bool requiresRewardedAd;

		private bool currentlyInAd;

		private readonly RewardedCheckNoCost checkNoCost;

		private readonly bool hasCheckNoCost;

		public override bool IsInputBlocking => false;

		public override bool IsInputBlockingNow => false;

		public override GameObject GameObject => null;

		public RewardedAdRequirement(GameObject root)
		{
		}

		public RewardedAdRequirement(GameObject root, RewardedCheckNoCost action)
		{
		}

		public RewardedAdRequirement(GameObject root, Vector3 displayOffset)
		{
		}

		public RewardedAdRequirement(GameObject root, RewardedCheckNoCost action, Vector3 displayOffset)
		{
		}

		public override UseGUIResult GetCanUseGUIResult()
		{
			return (UseGUIResult)0;
		}

		public override UseRequirementType GetRequirementType()
		{
			return UseRequirementType.Level;
		}

		public override int GetRequirementValue()
		{
			return 0;
		}

		public override ShowUseOption GetShowOption()
		{
			return ShowUseOption.Normal;
		}

		public override void OnDataUpdate(Dictionary<object, object> data, int ownerID)
		{
		}

		public override void SetScale(Vector3 scale)
		{
		}

		private void CreateDisplayObject()
		{
		}

		public override void DestroyRequirement(Dictionary<object, object> data)
		{
		}

		public override void PayUseCost()
		{
		}

		private void OnAdFinished(bool adWasSuccessful)
		{
		}

		public override bool IsActive()
		{
			return false;
		}

		public override void CalculatePosAroundPivot(Vector3 pivot, float spacingAngle, float distanceFromPivot)
		{
		}
	}
}
