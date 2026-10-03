using MV.WorldObject;

public class InteractionDataHandler : InteractionDataHandlerBase
{
	public override MVTeam Team => MVTeam.Blue;

	public MVWorldObjectClient WorldObjectParent
	{
		set
		{
		}
	}

	public override bool HandleInteraction(MVPickupOwner interactor, InteractionData interaction, bool interactionIsLocal)
	{
		return false;
	}
}
