using MV.WorldObject;
using UnityEngine;

public class SpawnRolePlateTintObject : TintObject
{
	[SerializeField]
	private MeshRenderer meshRenderer;

	[SerializeField]
	private Material materialToTint;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void TeamTint(MVTeam team)
	{
	}

	public override void Tint(Color c)
	{
	}
}
