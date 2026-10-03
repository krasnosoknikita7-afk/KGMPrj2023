using System.Collections.Generic;
using UnityEngine;

public class MoveableController : IUpdatecontrollerSubscriberFixedUpdate, IUpdatecontrollerSubscriberBase
{
	public Dictionary<int, Vector3> Velocities;

	public Dictionary<int, MVMovable> MoveControllers;

	public Dictionary<int, MVMovable> CubeModelMovableMap;

	public float time;

	public void AddMovable(MVMovable movable, bool isInventoryPreviewMovable)
	{
	}

	public void RemoveMovable(MVMovable movable)
	{
	}

	public void ResetMoveables()
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	public void SyncTimeToServer()
	{
	}

	public void UpdateMoveables(float directionFactor)
	{
	}

	public void UpdateSingleMoveableInChain(int movableGameObjectID, float directionFactor)
	{
	}

	public void UpdateMoveable(int movableGameObjectID, float directionFactor, int breakid)
	{
	}

	public Quaternion GetRotationQuat(int movableGameObjectID)
	{
		return default;
	}

	public Vector3 GetVel(int movableGameObjectID, Vector3 position)
	{
		return default;
	}
}
