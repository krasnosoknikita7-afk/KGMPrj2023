using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemPurchasePopup : MonoBehaviour
{
	[SerializeField]
	private Text cost;

	[SerializeField]
	private Text nonSubscriberCost;

	[SerializeField]
	private Text itemName;

	[SerializeField]
	private RawImage itemImage;

	[SerializeField]
	private Text description;

	[SerializeField]
	private ItemPurchaseConfirmationPopup confirmationPopup;

	private ShopItem item;

	private void Initialize(RawImage image, string nameText, string priceGold, string desc)
	{
	}

	public void Initialize(RawImage image, ShopItem shopItem)
	{
	}

	public void Initialize(RawImage image, InventoryItem invItem)
	{
	}

	public void OnPurchaseClicked()
	{
	}

	private void PurchaseItem(IPurchaseClientShopItem x)
	{
	}

	private void ConfirmationCallback(bool result)
	{
	}
}
