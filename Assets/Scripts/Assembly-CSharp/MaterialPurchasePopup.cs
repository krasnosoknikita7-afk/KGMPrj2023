using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MaterialPurchasePopup : MonoBehaviour
{
	private Dictionary<object, object> purchaseResponseData;

	private UnityAction<bool, Dictionary<object, object>> callback;

	private byte materialID;

	[SerializeField]
	private Text price;

	[SerializeField]
	private Text productName;

	[SerializeField]
	private Text description;

	[SerializeField]
	private RawImage materialPreviewImage;

	[SerializeField]
	private MaterialPreviewer materialPreviewer;

	[SerializeField]
	private GameObject purchaseButton;

	public void Initialize(byte materialID, UnityAction<bool, Dictionary<object, object>> callback)
	{
	}

	private void OnDestroy()
	{
	}

	public void OnPurchaseClick()
	{
	}

	private void OnConfirmed(bool confirmed, ConfirmationPopup confirmationPopup)
	{
	}

	private void ProductPurchaseResponseHandler(int returnCode, Dictionary<object, object> purchaseResponseData)
	{
	}
}
