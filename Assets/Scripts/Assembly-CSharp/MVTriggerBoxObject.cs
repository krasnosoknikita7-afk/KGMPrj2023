using UnityEngine;

public class MVTriggerBoxObject : ObjectPrefab
{
	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	public GameObject useInteractionRotator;

	public GameObject VisualObject => null;

	public TriggerBoxEvents TriggerBoxEvents => null;

	protected override void OnValidate()
	{
	}
}
