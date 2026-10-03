using UnityEngine;

public class FlagTintObject : TintObject
{
	[SerializeField]
	private MeshRenderer meshRenderer;

	[SerializeField]
	private Material materialToTint;

	[SerializeField]
	private Material materialBlack;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Tint(Color c)
	{
	}
}
