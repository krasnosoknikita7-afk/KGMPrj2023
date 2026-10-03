using System;
using UnityEngine;

public class FireObject : ObjectPrefab
{
	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private ParticleSystem fireParticleSystem;

	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private Collider fireCollider;

	[SerializeField]
	private AnimationCurve soundIntensityScale;

	public Action OnFireObjectCreated;

	public TriggerBoxEvents TriggerBoxEvents => null;

	public ParticleSystem ParticleSystem => null;

	public AudioSource AudioSource => null;

	public Collider FireCollider => null;

	public GameObject VisualObject => null;

	public AnimationCurve SoundIntensityScale => null;

	private void OnEnable()
	{
	}
}
