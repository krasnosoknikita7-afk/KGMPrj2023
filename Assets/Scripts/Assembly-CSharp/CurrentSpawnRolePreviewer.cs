using UnityEngine;
using UnityEngine.UI;

public class CurrentSpawnRolePreviewer : MonoBehaviour
{
	[SerializeField]
	private RawImage previewImage;

	[SerializeField]
	private AvatarPreviewer previewerPrefab;

	[SerializeField]
	private GameObject dropShadowPlane;

	private Transform avatarResetToTransform;

	private MVBody avatarBody;

	private GameObject bodyClone;

	private Animation goAnimation;

	private AvatarPreviewer previewer;

	public void SetupPreviewer(int previewDimensionsX = 512, int previewDimensionsY = 1024)
	{
	}

	public void ChangeAnimation(string NewAnimation)
	{
	}

	private void RemoveSkinnedMeshOptimizers()
	{
	}

	private void OnDestroy()
	{
	}
}
