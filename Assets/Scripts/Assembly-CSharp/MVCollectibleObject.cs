using UnityEngine;

public class MVCollectibleObject : ObjectPrefab
{
	[SerializeField]
	private StreamedSharedMaterialHandler handler;

	[SerializeField]
	private GreyOutObjectScript pickupItem;

	[SerializeField]
	private GameObject pickupMesh;

	[SerializeField]
	private ObjectParticleEmitterScript particles;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private WorldObjectEnableController worldObjectEnableController;

	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private AllWorldObjectTriggerBoxEvents allWorldObjectTriggerBoxEvents;

	[SerializeField]
	private CollectibleEffects collectibleEffects;

	public GreyOutObjectScript PickupItem => null;

	public GameObject PickupMesh => null;

	public ObjectParticleEmitterScript Particles => null;

	public AudioSource AudioSource => null;

	public WorldObjectEnableController WorldObjectEnableController => null;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public AllWorldObjectTriggerBoxEvents AllWorldObjectTriggerBoxEvents => null;

	public CollectibleEffects CollectibleEffects => null;

	private void Start()
	{
	}

	protected override void OnValidate()
	{
	}
}
