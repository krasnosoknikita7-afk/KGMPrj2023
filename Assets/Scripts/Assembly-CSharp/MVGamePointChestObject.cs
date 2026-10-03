using UnityEngine;

public class MVGamePointChestObject : ObjectPrefab
{
	[SerializeField]
	private ObjectParticleEmitterScript particles;

	[SerializeField]
	private GamePointChestModelController modelSelector;

	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private GameObject visualObject;

	public GameObject useInteractionRotator;

	public ObjectParticleEmitterScript Particles => null;

	public GamePointChestModelController ModelSelector => null;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public AudioSource AudioSource => null;

	public GameObject VisualObject => null;

	protected override void OnValidate()
	{
	}
}
