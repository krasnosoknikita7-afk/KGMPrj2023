using UnityEngine;

public class MVSentryGunObject : ObjectPrefab
{
	[SerializeField]
	private SentryGunScript sentryGunScript;

	[SerializeField]
	private AudioSource audioSource;

	public SentryGunScript SentryGunScript => null;

	public AudioSource AudioSource => null;

	protected override void OnValidate()
	{
	}
}
