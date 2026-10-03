using System.Collections.Generic;
using UnityEngine;

public class GameCoinLogic : UseRequirement
{
	private int purchaseAmount;

	private UseRequirementType requirementType;

	private Vector3 displayObjectOffset;

	private GameObject displayGO;

	private GameCoinDisplayObject displayObject;

	private GameObject displayObjectRoot;

	private bool hasUseWhenFree;

	public int PurchaseAmount => 0;

	public override GameObject GameObject => null;

	public GameCoinLogic(GameObject root, bool hasUseButtonWhenFree = true)
	{
	}

	public GameCoinLogic(GameObject root, Vector3 displayObjectOffset, bool hasUseButtonWhenFree = true)
	{
	}

	public override UseGUIResult GetCanUseGUIResult()
	{
		return (UseGUIResult)0;
	}

	public override bool IsActive()
	{
		return false;
	}

	public override void PayUseCost()
	{
	}

	public override void OnDataUpdate(Dictionary<object, object> data, int ownerID)
	{
	}

	private void CreateDisplayObject()
	{
	}

	private void DestroyDisplayObject()
	{
	}

	public override void SetScale(Vector3 scale)
	{
	}

	private void SetAmount(Dictionary<object, object> data, int ownerID)
	{
	}

	public override void DestroyRequirement(Dictionary<object, object> data)
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

	public override void CalculatePosAroundPivot(Vector3 pivot, float spacingAngle, float distanceFromPivot)
	{
	}
}
