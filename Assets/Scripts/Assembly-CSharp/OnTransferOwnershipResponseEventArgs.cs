using System;

public class OnTransferOwnershipResponseEventArgs : EventArgs
{
	public int worldObjectID;

	public int ownerActorNr;

	public bool success;

	public OnTransferOwnershipResponseEventArgs(int worldObjectID, int ownerActorNr, bool success)
	{
	}
}
