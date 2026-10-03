using MV.WorldObject;

internal class ClientSideLogicInteractionHandler : InteractionDataHandlerBase
{
	public override MVTeam Team => MVTeam.Blue;

	public override bool CanHandle(InteractionPackageType interactionPackageType, bool interactionIsLocal)
	{
		return false;
	}

	public override bool HandleInteraction(MVPickupOwner interactor, InteractionData interaction, bool interactionIsLocal)
	{
		return false;
	}
}
