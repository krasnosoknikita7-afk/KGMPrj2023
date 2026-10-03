using UnityEngine;

public class MVGameCoinChestObject : ObjectPrefab
{
	[SerializeField]
	private ObjectParticleEmitterScript particles;

	[SerializeField]
	private GameCoinChestModelSelector modelSelector;

	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private GameObject visualObject;

	public GameObject useInteractionRotator;

	public ObjectParticleEmitterScript Particles => null;

	public GameCoinChestModelSelector ModelSelector => null;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public AudioSource AudioSource => null;

	public GameObject VisualObject => null;

	protected override void OnValidate()
	{
	}
}
