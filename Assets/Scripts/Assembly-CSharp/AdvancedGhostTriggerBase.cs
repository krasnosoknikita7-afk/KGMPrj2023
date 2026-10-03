using System.Collections.Generic;
using UnityEngine;

public class AdvancedGhostTriggerBase : MonoBehaviour
{
	protected HashSet<int> attackTargets;

	public int[] AttackTargets => null;

	private void Reset()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void AddTarget(Collider other)
	{
	}

	private bool TryGetValidWorldObjectID(Collider collider, out int woID)
	{
		woID = default;
		return false;
	}

	private void LateUpdate()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
