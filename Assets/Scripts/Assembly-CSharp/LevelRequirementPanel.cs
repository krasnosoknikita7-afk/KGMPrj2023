using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LevelRequirementPanel : MonoBehaviour
{
	[SerializeField]
	private RawImage levelRequirementImage;

	private Texture2D levelRequirementTextureAsset;

	private int prevLevel;

	private int desiredLevel;

	public void SetLevelSpriteFromCallback(int level)
	{
	}

	private void OnLevelingIsReady()
	{
	}

	private void SetLevelBadge()
	{
	}

	private void OnDestroy()
	{
	}

	private void StreamingAssetCallback(UnityWebRequest www)
	{
	}
}
