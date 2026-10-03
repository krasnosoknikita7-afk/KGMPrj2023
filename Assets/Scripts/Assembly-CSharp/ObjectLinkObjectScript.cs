using MV.WorldObject;
using UnityEngine;

public class ObjectLinkObjectScript : LinkObjectBase
{
	[SerializeField]
	private BoxCollider boxCollider;

	[SerializeField]
	private LineRenderer lineRenderer;

	private void Awake()
	{
	}

	public void Initialize(ObjectLink link)
	{
	}

	private bool UpdatePositions(ObjectLink link)
	{
		return false;
	}

	public void UpdateLinkVisual(ObjectLink link)
	{
	}
}
