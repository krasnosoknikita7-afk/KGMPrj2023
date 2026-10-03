using UnityEngine;

public class PhysicsCollisionData
{
	public Vector3 point;

	public Transform transform;

	public bool isInsideCollider;

	public float distance;

	public Vector3 normal;

	public Collider collider;

	public void Set(RaycastHit hit)
	{
	}

	public void Set(Collider collider, Vector3 origin)
	{
	}

	public void Clear()
	{
	}
}
