using UnityEngine;

public class AvatarPooledXPParticles : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem xpParticleSystem;

	private bool hasStarted;

	private float initStartTime;

	private const float waitBeforeStartDuration = 1.2f;

	private const float particleMultipier = 1f;

	private void Update()
	{
	}

	public void Initialize(int xpDelta)
	{
	}
}
