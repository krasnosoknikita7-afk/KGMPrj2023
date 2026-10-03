using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EditModeRepositoryController : MonoBehaviour
{
	private ShopItem currentlyBuyingItem;

	public void PurchaseClientShopItem(ShopItem item, UnityAction UpdateContent)
	{
	}

	private void OnConfirmed(bool confirmed, ConfirmationPopup confirmationPopup)
	{
	}

	private void PurchaseClientShopItem()
	{
	}

	public void ProductPurchaseResponseHandler(int returnCode, Dictionary<object, object> data)
	{
	}
}
