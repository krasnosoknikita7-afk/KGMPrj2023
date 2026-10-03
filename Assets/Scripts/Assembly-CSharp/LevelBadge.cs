using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LevelBadge : MonoBehaviour
{
	[SerializeField]
	private RawImage levelBadge;

	[SerializeField]
	private ProgressBarAndroid xpBar;

	[SerializeField]
	private ProgressBarAndroid subscriberXPBar;

	private Texture2D badgeTextureAsset;

	private void Awake()
	{
	}

	private void OnLevelingInitialized()
	{
	}

	private void UpdateProgress(XPProgressData xpProgress)
	{
	}

	private void UpdateBadge(int level)
	{
	}

	private void OnDestroy()
	{
	}

	private void StreamingAssetCallback(UnityWebRequest www)
	{
	}
}
