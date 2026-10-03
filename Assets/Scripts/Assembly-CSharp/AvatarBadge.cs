using UnityEngine;
using UnityEngine.Networking;

public class AvatarBadge : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer badgeRenderer;

	[SerializeField]
	private TextMesh levelText;

	[SerializeField]
	private ScaleAnimations scaleAnimation;

	private Texture badgeTextureAsset;

	private int ownerActorId;

	public void Initialize(int ownerActorId)
	{
	}

	private void OnLevelingInitialized()
	{
	}

	private void UpdateBadge(int level)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnBadgeTextureReceived(UnityWebRequest www)
	{
	}

	private void ScaleAnimationIntermediateCallback(float extraTime)
	{
	}
}
