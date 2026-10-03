using System;
using MV.WorldObject;

public class ChunkInstancesChanged : EventArgs
{
	public enum ChangeType
	{
		Added = 0,
		Removed = 1,
		Clear = 2
	}

	public readonly ChangeType changeType;

	public readonly IntVector chunkPos;

	public ChunkInstancesChanged(ChangeType changeType, IntVector chunkPos)
	{
	}
}
