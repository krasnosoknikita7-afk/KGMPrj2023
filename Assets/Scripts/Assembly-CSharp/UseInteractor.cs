using System;
using System.Collections.Generic;
using UnityEngine;

public class UseInteractor
{
	private Func<int, bool> useFunction;

	private Func<int, MVInteractableBase, bool> checkCanUseFunction;

	private Collider triggerCollider;

	private bool reset;

	private int woOwnerID;

	private UseInteractorVisualization useInteractorVisuals;

	public bool Reset => false;

	public Collider TriggerCollider => null;

	public int WoOwnerID => 0;

	public bool UsedInVehicles { get; }

	public UseInteractor(MVWorldObjectClient wo, GameObject owner, bool reset, Collider triggerCollider, Func<int, bool> useFunction, Func<int, MVInteractableBase, bool> checkCanUseFunction = null, float yOffset = 2.5f, bool usedInVehicles = false)
	{
	}

	public bool GetInteractorCanBeUsed(int woId, MVInteractableBase avatarInteractable)
	{
		return false;
	}

	public bool Use(int userWoID)
	{
		return false;
	}

	private UseInteractorHandler GetUseInteractorHandler(int woID)
	{
		return null;
	}

	public void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	public void triggerBoxEvents_TriggerExit(object sender, TriggerEventArgs e)
	{
	}

	public void UpdateData(Dictionary<object, object> data)
	{
	}

	public void AddRequirement(UseRequirement useRequirement)
	{
	}

	public UseGUIResult EvaluateRequirementsUsability()
	{
		return (UseGUIResult)0;
	}

	public bool HasUseRequirements()
	{
		return false;
	}

	public ShowUseOption GetGUIShowOptions()
	{
		return ShowUseOption.Normal;
	}

	public void PayUseCost()
	{
	}

	public void OnDestroy(Dictionary<object, object> data)
	{
	}
}
