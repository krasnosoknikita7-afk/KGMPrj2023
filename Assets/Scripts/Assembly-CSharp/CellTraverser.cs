using MV.WorldObject;
using UnityEngine;

public class CellTraverser
{
	private Ray intersectRay;

	private Vector3 tMax;

	private Vector3 initialtMax;

	private IntVector localChunkSpaceVoxelPos;

	private int stepX;

	private int stepY;

	private int stepZ;

	private int chunkSize;

	private IntVector voxelPos;

	private IntVector stepDir;

	private Vector3 tDelta;

	public RuntimePrototypeCubeModel debugRpcm;

	public IntVector VoxelPos => default;

	public IntVector StepDir => default;

	public void Init(Vector3 localOrigin, CollisionState collisionState)
	{
	}

	public void DebugAll()
	{
	}

	public bool Step()
	{
		return false;
	}
}
