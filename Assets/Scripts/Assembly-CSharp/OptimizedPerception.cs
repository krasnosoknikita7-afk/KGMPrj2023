using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class OptimizedPerception
{
	private Vector3 position;

	private float radius;

	private HashSet<int> potentialTargets;

	private HashSet<int> removeSet;

	private List<WorldObjectClientRef> targets;

	public void Update(Vector3 position, float radius)
	{
	}

	public List<WorldObjectClientRef> GetTargets(MVTeam alliedTeam)
	{
		return null;
	}

	private bool GetValidTarget(int woID, MVTeam alliedTeam, out WorldObjectClientRef wo)
	{
		wo = null;
		return false;
	}

	private void UpdatePotentialTargets()
	{
	}
}
