using UnityEngine;

public class MVPickupItemBaseObject : ObjectPrefab
{
	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private GreyOutObjectScript pickupItem;

	public GameObject useInteractionRotator;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public AudioSource AudioSource => null;

	public GreyOutObjectScript PickupItem => null;

	protected override void OnValidate()
	{
	}
}
