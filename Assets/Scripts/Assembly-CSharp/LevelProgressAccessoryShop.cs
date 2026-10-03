using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LevelProgressAccessoryShop : MonoBehaviour
{
	[SerializeField]
	private Text progressText;

	[SerializeField]
	private ProgressBar progressBar;

	[SerializeField]
	private RawImage badgeTexture;

	private Texture2D badgeTextureAsset;

	private int badgeLevel;

	public void Start()
	{
	}

	private void Initialize()
	{
	}

	private void OnXPUpdate(XPProgressData xpProgressData)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLevelingBadgeLoaded(UnityWebRequest www)
	{
	}
}
