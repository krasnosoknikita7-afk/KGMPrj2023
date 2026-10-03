using MV.WorldObject.GamePassSystem.GamePassEarnings;
using UnityEngine;
using UnityEngine.UI;

public class GameSetupMenu : MonoBehaviour
{
	[SerializeField]
	private GameObject activeGameTierButton;

	[SerializeField]
	private GameObject inActiveGameTierButton;

	[SerializeField]
	private Text earningsAmountText;

	[SerializeField]
	private GamePassesShopDetails gamePassesShopDetailsPrefab;

	[SerializeField]
	private BoostEditMenu boosterEditMenuPrefab;

	[SerializeField]
	private GameEarningsMenu earningsMenuPrefab;

	[SerializeField]
	private GameObject crystalPopupPrefab;

	[SerializeField]
	private GameSetupOptions optionsMenuPrefab;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateTierButtonVisibility()
	{
	}

	private void OnRecieveEarningsReport(ProjectEarningsReport projectEarningsReport)
	{
	}

	private void UpdateEarningText(ProjectEarningsReport projectEarningsReport)
	{
	}

	public void ShowGamePassesShopDetails()
	{
	}

	public void ShowBoostEditMenu()
	{
	}

	public void OnInactiveTierButtonPressed()
	{
	}

	public void ShowGameEarnings()
	{
	}

	public void ShowMiscOptions()
	{
	}
}
