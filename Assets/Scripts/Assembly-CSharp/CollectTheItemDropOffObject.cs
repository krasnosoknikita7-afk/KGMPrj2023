using UnityEngine;

public class CollectTheItemDropOffObject : ObjectPrefab
{
	[SerializeField]
	private Collider editCollider;

	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private CollectTheItemBlinker blinker;

	[SerializeField]
	private GameObject cullingObject;

	[SerializeField]
	private GreyOutObjectScript greyout;

	public GameObject CullingObject => null;

	public CollectTheItemBlinker Blinker => null;

	public GameObject VisualObject => null;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public Collider EditCollider => null;

	public GreyOutObjectScript GreyOutScript => null;

	protected override void OnValidate()
	{
	}
}
