using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarAccessoryPurchasePopup : MonoBehaviour
{
	private AccessoryDataClient accessoryDataClient;

	[SerializeField]
	private StreamedSpriteToImageManual preview;

	[SerializeField]
	private GameObject loadingWheel;

	[SerializeField]
	private Text priceText;

	[SerializeField]
	private Text originalPriceText;

	[SerializeField]
	private GameObject discountTag;

	[SerializeField]
	private GameObject freeItemTag;

	[SerializeField]
	private Text discountTagText;

	[SerializeField]
	private AccessoryItemBackground accessoryItemBackground;

	[SerializeField]
	private AccessoryTimeLimitDisplayer timeLimitDisplayer;

	[SerializeField]
	private GameObject newAccessoryImage;

	[SerializeField]
	private AvatarAccessorySuccesPopup avatarAccessorySuccesPopup;

	[SerializeField]
	private AvatarAccessoryErrorPopup insufficientResourcesPopup;

	[SerializeField]
	private PurchasedAccessoryPreviewer successPreviewer;

	[SerializeField]
	private GameObject emptyFrame;

	private int price;

	private string previewImageUrl;

	public void Initialize(AccessoryDataClient accessoryDataClient, string previewImageUrl)
	{
	}

	public void Purchase()
	{
	}

	private void ProductPurchaseResponseHandler(int returnCode, Dictionary<object, object> purchaseResponseData)
	{
	}

	private void HandleInsufficientResources(string header, string buttonText)
	{
	}

	private void OnGoldPurchaseDialogResult(bool result)
	{
	}

	private void HandleSuccessfulPurchase(Dictionary<object, object> purchaseResponseData)
	{
	}

	private void SuccessfulPopupCallBack(int streamingAssetId)
	{
	}

	public void Pop()
	{
	}

	private void HandlePrices(AccessoryDataClient streamingAssetInfo)
	{
	}

	private void HandleNotOwnedUI()
	{
	}

	private void OnPreviewImageDownLoaded()
	{
	}
}
