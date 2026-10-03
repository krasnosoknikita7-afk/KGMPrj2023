using System.Collections.Generic;

public class MVNetworkSelector
{
	private readonly EditorStateMachine esm;

	private Queue<int> pendingRequestedOwnershipIds;

	private static MVWorldObjectClientManager WOCM => null;

	public MVNetworkSelector(EditorStateMachine esm)
	{
	}

	public bool RequestOwnership(HashSet<int> selectionSet)
	{
		return false;
	}

	public bool CanRequestOwnerShip(int id)
	{
		return false;
	}

	public void RequestReleaseOwnership(HashSet<int> selectionSet)
	{
	}

	private static bool CanRequestOwnership(HashSet<int> selectionSet)
	{
		return false;
	}

	private static bool OwnershipTest(int id)
	{
		return false;
	}

	private void RequestOwnership(int id)
	{
	}

	private static void RequestReleaseOwnership(int id)
	{
	}

	private void Instance_OnWorldObjectTransferOwnershipResponse(object sender, OnTransferOwnershipResponseEventArgs e)
	{
	}
}
