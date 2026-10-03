using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BundleView : MonoBehaviour
{
	[SerializeField]
	private Text originalPriceText;

	[SerializeField]
	private Text discountedPriceText;

	[SerializeField]
	private Text bundlePriceWithoutDiscount;

	[SerializeField]
	private GameObject discountTag;

	[SerializeField]
	private Text discountTagText;

	[SerializeField]
	private Text goldSavedText;

	[SerializeField]
	private PurchasedAccessoryPreviewer previewSlideshowPrefab;

	[SerializeField]
	private Image levelLocked;

	[SerializeField]
	private BundlePurchasePopUp bundlePurchasePopup;

	[SerializeField]
	private BundleErrorPopUp bundleErrorPopUp;

	[SerializeField]
	private LevelErrorPopup levelErrorPopUp;

	[SerializeField]
	private GameObject claimText;

	[SerializeField]
	private Button purchaseButton;

	[SerializeField]
	private AccessoryShinyButton shineEffect;

	private AccessoryBundleClient bundleData;

	private int price;

	private int originalPrice;

	public void Initialize()
	{
	}

	public void OnBundlePurchaseClicked()
	{
	}

	private void OnPurchaseBundleConfirmation(bool confirmed)
	{
	}

	private void ProductPurchaseResponseHandler(int returnCode, Dictionary<object, object> purchaseResponseData)
	{
	}

	private void OnPop()
	{
	}

	private void OnInsufficientResourceCallback(bool confirmed)
	{
	}

	private void OnInsufficientLevelCallback()
	{
	}

	private void HandlePrices(AccessoryBundleClient accessoryData)
	{
	}

	private void HandleLevel(AccessoryBundleClient accessoryData)
	{
	}
}
