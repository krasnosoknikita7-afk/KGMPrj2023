using MV.WorldObject;
using UnityEngine;

public class TriggerCubeTintObject : TintObject
{
	[SerializeField]
	private MeshRenderer meshRendererToTint;

	[SerializeField]
	private Material materialCylinderToTint;

	private Color OriginalColor;

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
