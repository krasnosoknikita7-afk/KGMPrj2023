using System.Collections.Generic;
using UnityEngine;

public class PhysicsCollisionDatasWrapper
{
	private int length;

	private readonly List<PhysicsCollisionData> physicsCollisionDatas;

	public int Length => 0;

	public PhysicsCollisionData this[int key] => null;

	public void Clear()
	{
	}

	public void Add(RaycastHit hit)
	{
	}

	public void Add(Collider collider, Vector3 origin)
	{
	}
}
