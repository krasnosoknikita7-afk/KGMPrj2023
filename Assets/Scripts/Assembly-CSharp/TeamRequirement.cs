using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class TeamRequirement : UseRequirement
{
	public const string teamStr = "team";

	private TintObject tintObject;

	private MVTeam team;

	private bool hasUseButtonWhenFree;

	public override GameObject GameObject => null;

	public TintObject ToTint
	{
		set
		{
		}
	}

	public TeamRequirement(TintObject tintObject, bool hasUseButtonWhenFree = true)
	{
	}

	public override UseGUIResult GetCanUseGUIResult()
	{
		return (UseGUIResult)0;
	}

	public override void PayUseCost()
	{
	}

	public override void DestroyRequirement(Dictionary<object, object> data)
	{
	}

	public override void OnDataUpdate(Dictionary<object, object> data, int ownerID)
	{
	}

	public override ShowUseOption GetShowOption()
	{
		return ShowUseOption.Normal;
	}

	public override int GetRequirementValue()
	{
		return 0;
	}

	public override UseRequirementType GetRequirementType()
	{
		return UseRequirementType.Level;
	}

	public override bool IsActive()
	{
		return false;
	}

	public override void CalculatePosAroundPivot(Vector3 pivot, float spacingAngle, float distanceFromPivot)
	{
	}

	public override void SetScale(Vector3 scale)
	{
	}
}
