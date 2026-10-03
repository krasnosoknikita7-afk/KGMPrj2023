using System.Collections.Generic;
using UnityEngine;

public class SmoothPhysicsMovement : MonoBehaviour
{
	private class Package
	{
		public readonly Vector3 position;

		public readonly Quaternion rotation;

		public readonly float time;

		public Package(Vector3 position, Quaternion rotation)
		{
		}
	}

	private Queue<Package> packages;

	private CullingSubscriberBase cullingSubscriberBase;

	private MVWorldObjectClient worldObjectOwner;

	private Package next;

	private Package current;

	private Transform targetTransform;

	public void Init(Transform targetTransform, CullingSubscriberBase cullingSubscriberBase, MVWorldObjectClient worldObjectOwner)
	{
	}

	public void SmoothMove()
	{
	}

	public void Reset()
	{
	}

	private void FixedUpdate()
	{
	}
}
