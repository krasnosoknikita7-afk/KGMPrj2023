using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TierPurchasePopup : MonoBehaviour
{
	[SerializeField]
	private Text tierText;

	[SerializeField]
	private Text priceText;

	private GamePassTier tierToPurchase;

	private int price;

	private UnityAction OnPurchaseSuccessful;

	public void Initialize(GamePassTier tierToPurchase, int price, UnityAction OnPurchaseSuccessful)
	{
	}

	public void Purchase()
	{
	}

	public void Cancel()
	{
	}

	private void ProductPurchaseResponseHandler(int returnCode, Dictionary<object, object> purchaseResponseData)
	{
	}

	private void HandleSuccessfulPurchase()
	{
	}
}
