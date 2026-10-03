using UnityEngine;

public class SoundEmitterObject : ObjectPrefab
{
	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private SoundEmitterActiveCheck soundCheck;

	[SerializeField]
	private AudioSource audioSource;

	public GameObject VisualObject => null;

	public SoundEmitterActiveCheck SoundCheck => null;

	public AudioSource AudioSource => null;
}
