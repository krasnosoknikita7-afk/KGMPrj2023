using UnityEngine;

public class AndroidInGameMenu : MonoBehaviour
{
	[SerializeField]
	private GameObject touristRegisterButton;

	[SerializeField]
	private TimedPlayReward playReward;

	[SerializeField]
	private GameObject winningConditionDebriefing;

	[SerializeField]
	private GamePassesUI gamePassesUIPrefab;

	[SerializeField]
	private FreeGoldAndroid rewardedAd;

	[SerializeField]
	private GameObject claimGoldRewardPopupPrefab;

	[SerializeField]
	private GameObject accessoryShopButton;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private GamePassesUI gamePassesUI;

	public void Initialize()
	{
	}

	private void OnEnable()
	{
	}
}
