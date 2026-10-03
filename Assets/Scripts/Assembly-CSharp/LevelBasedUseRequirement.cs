using System.Collections.Generic;
using UnityEngine;

public class LevelBasedUseRequirement : UseRequirement
{
	private int levelAmount;

	private const UseRequirementType RequirementType = UseRequirementType.Level;

	private readonly bool hasUseWhenFree;

	private LevelDisplayCube displayObject;

	private Vector3 displayObjectOffset;

	private readonly GameObject displayObjectRoot;

	private GameObject go;

	public override GameObject GameObject => null;

	public LevelBasedUseRequirement(GameObject root, bool hasUseButtonWhenFree = true)
	{
	}

	public LevelBasedUseRequirement(GameObject root, Vector3 displayOffset, bool hasUseButtonWhenFree = true)
	{
	}

	public override UseGUIResult GetCanUseGUIResult()
	{
		return (UseGUIResult)0;
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
}
