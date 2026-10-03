using UnityEngine;

public class MVCountingCubeObject : ObjectPrefab
{
	[SerializeField]
	private GameObject visualObject;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private MVCountingCubeDigits digitManager;

	public AudioSource AudioSource => null;

	public MVCountingCubeDigits DigitManager => null;

	public GameObject VisualObject => null;

	protected override void OnValidate()
	{
	}
}
