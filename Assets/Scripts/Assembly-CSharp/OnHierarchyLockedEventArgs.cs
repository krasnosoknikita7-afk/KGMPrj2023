using System;

public class OnHierarchyLockedEventArgs : EventArgs
{
	public int worldObjectID;

	public bool success;

	public OnHierarchyLockedEventArgs(int worldObjectID, bool success)
	{
	}
}
