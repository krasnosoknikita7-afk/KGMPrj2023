using MV.WorldObject;

internal class ESAddToMarketPlaceState : ESStateBase
{
	private enum AddToMarketPlaceInternalState
	{
		None = 0,
		WaitingForMarketPlaceItem = 1,
		CompareMarketPlaceItemWithInventoryItem = 2,
		WaitingForMarketPlaceInfo = 3
	}

	private AddToMarketPlaceInternalState internalState;

	private BytePacker inventoryItemData;

	private BytePacker marketPlaceItemData;

	public override void Enter(EditorStateMachine e)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	private void WOCM_ReceivedItemFromQuery(object sender, ReceivedItemFromQueryEventArgs e)
	{
	}

	public override void Exit(EditorStateMachine e)
	{
	}
}
