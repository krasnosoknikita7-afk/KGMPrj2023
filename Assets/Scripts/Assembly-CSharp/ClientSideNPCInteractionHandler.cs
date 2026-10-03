using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class ClientSideNPCInteractionHandler : InteractionDataHandlerBase
{
	[SerializeField]
	private GameObject attachmentObjectForHealRay;

	private readonly HashSet<InteractionPackageType> unableToDamageNPCs;

	private readonly HashSet<InteractionPackageType> friendlyInteractions;

	private MVTeam team;

	public override MVTeam Team => MVTeam.Blue;

	public void SetTeam(MVTeam team)
	{
	}

	public override bool CanHandle(InteractionPackageType interactionPackageType, bool interactionIsLocal)
	{
		return false;
	}

	public override bool HandleInteraction(MVPickupOwner interactor, InteractionData interaction, bool interactionIsLocal)
	{
		return false;
	}

	public GameObject GetHealRayAttachmentObject()
	{
		return null;
	}
}
