using UnityEngine;

[RequireComponent(typeof(Projector))]
public class AvatarBlobShadowController : MonoBehaviour
{
	private const float baseScale = 1f;

	public Projector blobProjector;

	private bool forceHidden;

	public bool ForceHidden
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void ScaleShadow(float scale)
	{
	}

	private void OnQualityLevelChanged(int level)
	{
	}
}
