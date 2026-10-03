using UnityEngine;

public class MVCheckpointObject : ObjectPrefab
{
	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private Animation objAnimation;

	public GameObject useInteractionRotator;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public Animation Animation => null;

	public GameObject VisualObject => null;

	protected override void OnValidate()
	{
	}
}
