using System.Collections.Generic;
using UnityEngine;

public class StarRequirement : UseRequirement
{
	private int starAmount;

	private const UseRequirementType requirementType = UseRequirementType.Star;

	private Vector3 displayObjectOffset;

	private GameObject displayGO;

	private StarDisplayObject displayObject;

	private GameObject displayObjectRoot;

	private bool hasUseWhenFree;

	public int StarAmount => 0;

	public override GameObject GameObject => null;

	public StarRequirement(GameObject root, bool hasUseButtonWhenFree = true)
	{
	}

	public StarRequirement(GameObject root, Vector3 displayOffset, bool hasUseButtonWhenFree = true)
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

	public override bool IsActive()
	{
		return false;
	}

	public override void CalculatePosAroundPivot(Vector3 pivot, float spacingAngle, float distanceFromPivot)
	{
	}

	private int GetLocalPLayerStat()
	{
		return 0;
	}
}
