using UnityEngine;

public class MVGamePointObject : ObjectPrefab
{
	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private GreyOutObjectScript pickupItem;

	[SerializeField]
	private ObjectParticleEmitterScript particles;

	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private RotateLocal rotateLocal;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public AudioSource AudioSource => null;

	public GreyOutObjectScript PickupItem => null;

	public ObjectParticleEmitterScript Particles => null;

	public RotateLocal RotateLocal => null;

	public GameObject VisualObject => null;

	protected override void OnValidate()
	{
	}
}
