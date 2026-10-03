using UnityEngine;

public class FlagObject : ObjectPrefab
{
	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private TintObject tintObject;

	public GameObject useInteractionRotator;

	public GameObject VisualObject => null;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public TintObject TintObject => null;

	protected override void OnValidate()
	{
	}
}
