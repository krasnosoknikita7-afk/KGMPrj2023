using System.Collections.Generic;
using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class GameRankRequirement : UseRequirement
{
	private GamePassTier requiredRank;

	private UseRequirementType requirementType;

	private MVWorldObjectClient worldObject;

	private Vector3 displayObjectOffset;

	private GameObject displayGO;

	private GameRankDisplayObject displayObject;

	private GameObject displayObjectRoot;

	private bool hasUseWhenFree;

	private bool shouldDeleteWhenTier0;

	private WorldObjectType worldObjectType;

	public GamePassTier RequiredRank => GamePassTier.Tier0;

	public bool ShouldDeleteWhenTier0
	{
		set
		{
		}
	}

	public override GameObject GameObject => null;

	public GameRankRequirement(GameObject root, MVWorldObjectClient worldObject, bool hasUseButtonWhenFree = true)
	{
	}

	public GameRankRequirement(GameObject root, Vector3 displayOffset, MVWorldObjectClient worldObject, bool hasUseButtonWhenFree = true)
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

	public void OnDelete()
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

	public override bool IsActive()
	{
		return false;
	}

	public override void CalculatePosAroundPivot(Vector3 pivot, float spacingAngle, float distanceFromPivot)
	{
	}

	private GamePassTier GetLocalPLayerRank()
	{
		return GamePassTier.Tier0;
	}

	private GamePassTier GetLocalPlayerTempRank()
	{
		return GamePassTier.Tier0;
	}
}
