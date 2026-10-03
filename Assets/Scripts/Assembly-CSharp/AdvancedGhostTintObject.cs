using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class AdvancedGhostTintObject : TintObject
{
	[SerializeField]
	private List<OculusTeamGameObject> teamIrisObjects;

	public override void TeamTint(MVTeam team)
	{
	}

	public override void Tint(Color c)
	{
	}
}
