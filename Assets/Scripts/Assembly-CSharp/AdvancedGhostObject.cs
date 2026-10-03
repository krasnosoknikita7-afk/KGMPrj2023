using UnityEngine;

public class AdvancedGhostObject : ObjectPrefab
{
	[SerializeField]
	private AdvancedGhostTintObject tintObject;

	public TintObject TintObject => null;

	protected void Reset()
	{
	}

	protected override void OnValidate()
	{
	}
}
