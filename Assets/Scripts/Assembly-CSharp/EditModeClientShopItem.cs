using UnityEngine;
using UnityEngine.UI;

public class EditModeClientShopItem : MonoBehaviour
{
	[SerializeField]
	private RawImage previewImage;

	[SerializeField]
	private int previewWidth;

	[SerializeField]
	private int previewHeight;

	[SerializeField]
	private ItemPurchasePopup popup;

	[SerializeField]
	private InventoryItemPreviewer objectPreviewerPrefab;

	private ShopItem item;

	private InventoryItemPreviewer objectPreviewer;

	private bool initialized;

	private MVWorldObjectDocumentationType documentationType;

	public MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public void Initialize(Transform rootTransform, ShopItem item, MVWorldObjectClient woPreviewObject)
	{
	}

	public void SlotPressed()
	{
	}

	public void ShowPurchasePopUp()
	{
	}

	public void Update()
	{
	}

	public InventoryItem GetItem()
	{
		return null;
	}
}
