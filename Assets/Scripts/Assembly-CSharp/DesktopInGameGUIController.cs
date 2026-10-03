using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DesktopInGameGUIController : MonoBehaviour
{
	[SerializeField]
	private GameObject winningConditionLayoutGroup;

	[SerializeField]
	private ShowUse3D use3DPrefab;

	private ShowUse use;

	[SerializeField]
	private CrossHair crossHair;

	[SerializeField]
	private GameObject touristLogo;

	[SerializeField]
	private Image logo;

	[SerializeField]
	private LevelBadge levelBadge;

	[SerializeField]
	private GameObject leaveEditPlayModeButton;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private Dictionary<EmbeddedSite, string> logoToPathMap;

	public void Initialize()
	{
	}

	private void StreamingAssetCallback(UnityWebRequest www)
	{
	}

	public void ShowEUseIcon(ShowUseOption option, int woID = 0)
	{
	}

	public void HideEUseIcon()
	{
	}

	public IGUICrossHair GetCrossHair()
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
