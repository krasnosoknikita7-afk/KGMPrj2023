using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BundlePurchasePopUp : MonoBehaviour
{
	private AccessoryBundleClient bundleDataClient;

	[SerializeField]
	private Text priceText;

	[SerializeField]
	private Text originalPriceText;

	[SerializeField]
	private GameObject discountTag;

	[SerializeField]
	private Text discountTagText;

	[SerializeField]
	private AccessoryTimeLimitDisplayer timeLimitDisplayer;

	[SerializeField]
	private GameObject freeLabel;

	private int originalPrice;

	private UnityAction<bool> resultCallback;

	public void Initialize(AccessoryBundleClient bundleDataClient, int price, int originalPrice, UnityAction<bool> resultCallback)
	{
	}

	public void Purchase()
	{
	}

	public void Exit()
	{
	}

	private void OnGoldPurchaseDialogResult(bool result)
	{
	}

	public void Pop()
	{
	}

	private void HandlePrices(AccessoryBundleClient bundleDataClient)
	{
	}

	private void HandleNotOwnedUI()
	{
	}
}
