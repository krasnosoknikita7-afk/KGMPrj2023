using MV.WorldObject;
using UnityEngine;

public class TeleporterTintObject : TintObject
{
	[SerializeField]
	private MeshRenderer meshRendererToTint;

	[SerializeField]
	private Material materialCylinderToTint;

	[SerializeField]
	private ParticleSystem particleCircleToTint;

	[SerializeField]
	private Light lightToTint;

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
