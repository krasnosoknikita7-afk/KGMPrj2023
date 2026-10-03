using UnityEngine;
using UnityEngine.UI;

public class InGameMenu : MonoBehaviour
{
	[SerializeField]
	private GameObject respawnButton;

	[SerializeField]
	private GameObject touristRegisterButton;

	[SerializeField]
	private TimedPlayReward playReward;

	[SerializeField]
	private AdOfferGold adOfferGold;

	[SerializeField]
	private Image inGameMenuBlockingOverlay;

	[SerializeField]
	private GameObject winningConditionDebriefing;

	[SerializeField]
	private GamePassesUI gamePassesUIPrefab;

	[SerializeField]
	private GameObject claimGoldRewardPopupPrefab;

	[SerializeField]
	private GameObject accessoryShopButton;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	[SerializeField]
	private GameObject adminObserveButton;

	private GamePassesUI gamePassesUI;

	public void Initialize()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}
}
