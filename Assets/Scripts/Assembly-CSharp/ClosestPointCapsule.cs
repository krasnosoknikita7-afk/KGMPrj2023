using UnityEngine;

public class ClosestPointCapsule : ClosestPointBase
{
	[SerializeField]
	private CapsuleCollider capsule;

	private Transform Transform => null;

	private Vector3 Position => default;

	private Vector3 Scale => default;

	public ClosestPointCapsule(CapsuleCollider c)
	{
	}

	public override Vector3 GetClosestPoint(Vector3 from)
	{
		return default;
	}

	private void OnValidate()
	{
	}
}
