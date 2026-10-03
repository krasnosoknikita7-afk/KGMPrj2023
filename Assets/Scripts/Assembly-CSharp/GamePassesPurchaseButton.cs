using System.Collections.Generic;
using MV.Common;
using MV.WorldObject.GamePassSystem;
using UnityEngine;
using UnityEngine.UI;

public class GamePassesPurchaseButton : MonoBehaviour
{
	[SerializeField]
	private Text priceText;

	[SerializeField]
	private Text disabledPriceText;

	[SerializeField]
	private GameObject testToggle;

	[SerializeField]
	private GameObject freeTryButton;

	[SerializeField]
	private GameObject freeTryActivated;

	[SerializeField]
	private ToggleButtonAnimation toggleButton;

	[SerializeField]
	private Button purchaseButton;

	[SerializeField]
	private GameObject disabledPurchaseButton;

	[SerializeField]
	private GamePassesTextBubble informationTextBubble;

	private GamePassTier tierDisplayed;

	public bool IsPurchaseDisabled => false;

	public void Initialize(GamePassTier tierToDisplay)
	{
	}

	public void OnTestButtonPressed()
	{
	}

	public void OnDisabledButtonPressed()
	{
	}

	public void SetFreeTryActivated(bool isActive)
	{
	}

	private void OnDestroy()
	{
	}

	private void HideButton()
	{
	}

	private void SetUpTestButton()
	{
	}

	private void SetUpPurchaseButton(GamePassTier tierToDisplay, Dictionary<GamePassTier, PlayerTierState> gameTierShopStatus)
	{
	}

	private void SetUpDisableButton(GamePassTier tierToDisplay, Dictionary<GamePassTier, PlayerTierState> gameTierShopStatus)
	{
	}

	private void SetupFreeTryButton()
	{
	}

	private void UpdatePriceText()
	{
	}
}
