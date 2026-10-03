using UnityEngine;

public class TriggerCubePrefab : ObjectPrefab
{
	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private TriggerCubeTintObject tintObject;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public TriggerCubeTintObject TintObject => null;

	public void SetScale(Vector3 scale)
	{
	}

	protected override void OnValidate()
	{
	}
}
