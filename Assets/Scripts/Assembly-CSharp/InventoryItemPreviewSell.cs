using UnityEngine;
using UnityEngine.UI;

public class InventoryItemPreviewSell : ManageItemPage
{
	[SerializeField]
	private InputField itemName;

	[SerializeField]
	private InputField description;

	[SerializeField]
	private RawImage previewImage;

	[SerializeField]
	private Button removeFromMarketButton;

	[SerializeField]
	private Text sellButtonText;

	[SerializeField]
	private Button sellButton;

	[SerializeField]
	private ProgressBarAndroid compareSlider;

	[SerializeField]
	private RectTransform thresholdCaret;

	[SerializeField]
	private RectTransform sliderTransform;

	[SerializeField]
	private Text compareText;

	private InventoryItem previewItem;

	private bool addingToMarket;

	public override void Initialize(RawImage preview, InventoryItem item)
	{
	}

	public void AddToMarket()
	{
	}

	public void RemoveFromMarket()
	{
	}

	private void OnRemoveFromMarketplace(bool success)
	{
	}

	private void OnAddToMarketplaceReturn(bool success)
	{
	}

	private void OnLoadMarketPlaceItem(object sender, ReceivedItemFromQueryEventArgs e)
	{
	}
}
