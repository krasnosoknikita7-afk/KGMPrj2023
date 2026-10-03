using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class FadeAndDestroyOnParticleSystemFinish : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem system;

	private float fadeCountDown;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
