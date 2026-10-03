using UnityEngine;

public class MVTeleporterObject : ObjectPrefab
{
	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private ParticleSystem objParticleSystem;

	[SerializeField]
	private TeleporterTintObject tintObject;

	public GameObject visualRoot;

	public GameObject useInteractionRotator;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public ParticleSystem ParticleSystem => null;

	public TeleporterTintObject TintObject => null;

	protected override void OnValidate()
	{
	}
}
