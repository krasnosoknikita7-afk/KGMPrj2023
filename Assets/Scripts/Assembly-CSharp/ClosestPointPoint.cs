using UnityEngine;

public class ClosestPointPoint : ClosestPointBase
{
	[SerializeField]
	private new Transform transform;

	public void Init(Transform t)
	{
	}

	public override Vector3 GetClosestPoint(Vector3 from)
	{
		return default;
	}

	public Vector3 GetClosestPoint()
	{
		return default;
	}

	private void OnValidate()
	{
	}
}
