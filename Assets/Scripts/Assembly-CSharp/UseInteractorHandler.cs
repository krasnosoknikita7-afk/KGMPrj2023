using System.Collections.Generic;
using Assets.Scripts.Tools;
using UnityEngine;

public class UseInteractorHandler : MVComponent
{
	private const UseGUIResult UseGui = UseGUIResult.NoUseButton | UseGUIResult.NoCost | UseGUIResult.CanAfford | UseGUIResult.CannotAfford;

	private readonly Dictionary<int, UseInteractor> useInteractors;

	private readonly List<int> removeList;

	private ColliderCollection triggingColliders;

	private MVInteractableBase interactionBase;

	private int ownerWoId;

	public ColliderCollection TriggingColliders => null;

	public void Init(int ownerWoId, Collider baseCollider)
	{
	}

	public void AddUseInteractor(UseInteractor useInteractor)
	{
	}

	public void RemoveUseInteractor(UseInteractor useInteractor)
	{
	}

	private void UpdateInteractorsWOID()
	{
	}

	private void Update()
	{
	}

	private void UpdateUseVisuals()
	{
	}

	private List<UseInteractor> SortByDistance()
	{
		return null;
	}

	public bool Use()
	{
		return false;
	}

	public void Reset()
	{
	}
}
