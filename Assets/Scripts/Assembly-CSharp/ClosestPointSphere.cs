using UnityEngine;

public class ClosestPointSphere : ClosestPointBase
{
	[SerializeField]
	private Vector3 offset;

	[SerializeField]
	private float radius;

	protected void OnDrawGizmos()
	{
	}

	public override Vector3 GetClosestPoint(Vector3 spectator)
	{
		return default;
	}
}
