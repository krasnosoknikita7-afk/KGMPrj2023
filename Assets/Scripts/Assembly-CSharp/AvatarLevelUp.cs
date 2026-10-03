using UnityEngine;

public class AvatarLevelUp : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem onLevelUpParticleSystem;

	[SerializeField]
	private TextMesh levelText;

	[SerializeField]
	private ScaleAnimation scaleAnimation;

	private int ownerActorNr;

	public void Init(int ownerActorNr)
	{
	}

	private void OnScaleAnimationStopped(float extraTime)
	{
	}

	private void OnLevelChanged(int level)
	{
	}

	private void OnDestroy()
	{
	}
}
