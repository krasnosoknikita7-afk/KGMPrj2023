using UnityEngine;

public class TimeAttackFlagTintObject : TintObject
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

	public override void Tint(Color c)
	{
	}
}
