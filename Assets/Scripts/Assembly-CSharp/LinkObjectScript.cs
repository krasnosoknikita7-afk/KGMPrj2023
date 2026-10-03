using MV.WorldObject;
using UnityEngine;

public class LinkObjectScript : LinkObjectBase
{
	[SerializeField]
	private BoxCollider boxCollider;

	[SerializeField]
	private LineRenderer lineRenderer;

	private void Awake()
	{
	}

	public void Initialize(Link link)
	{
	}

	private bool UpdatePositions(Link link)
	{
		return false;
	}

	private Vector3 CalculateUnconnectedLinkPos(Vector3 connectedPos)
	{
		return default;
	}

	public void UpdateLinkVisual(Link link)
	{
	}
}
