using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class GamePassesUI : MonoBehaviour
{
	[SerializeField]
	private GamePassesShop gamePassesShopPrefab;

	[SerializeField]
	private Text totalGamePointAmountText;

	[SerializeField]
	private GamePassesHighScoreList highScoreListPrefab;

	[SerializeField]
	private GamePassesHighlightArrowManager highLightArrowManager;

	[SerializeField]
	private GameTierProgressBar tierProgressBar;

	[SerializeField]
	private GameTierProgressBarGainEffectController gainEffectController;

	[SerializeField]
	private GamePassesWelcomeReward welcomeRewardPopup;

	private bool isInitialized;

	public void Initialize()
	{
	}

	public void TryShowWelcomeReward()
	{
	}

	public void OnTier1ShopPressed()
	{
	}

	public void OnTier2ShopPressed()
	{
	}

	public void OnTier3ShopPressed()
	{
	}

	public void ShowHighScore()
	{
	}

	public void ReplayGainEffect(int previousGamePointAmount, int newGamePointAmount)
	{
	}

	private void ShowGamePassesShop(GamePassTier tierToShow)
	{
	}

	private void InstantiateGamePassesShop(GamePassTier tierToShow)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private bool ShouldShowWelcomeReward()
	{
		return false;
	}

	private void OnPlayerPlanetDataUpdated()
	{
	}
}
