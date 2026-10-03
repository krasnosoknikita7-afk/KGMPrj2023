using MV.WorldObject;
using UnityEngine;

public class PressurePlateTintObject : TintObject
{
	[SerializeField]
	private MeshRenderer meshRendererToTint;

	[SerializeField]
	private Material materialCylinderToTint;

	[SerializeField]
	private Texture teamTexture;

	[SerializeField]
	private Texture defaultTexture;

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
