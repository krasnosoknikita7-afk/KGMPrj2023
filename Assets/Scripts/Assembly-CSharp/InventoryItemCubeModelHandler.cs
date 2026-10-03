using UnityEngine;
using UnityEngine.UI;

public class InventoryItemCubeModelHandler : InventoryItemPreview
{
	[SerializeField]
	private InventoryItemPreviewSell inventoryItemPreviewSellPrefab;

	private InventoryItem previewedItem;

	public override void Initialize(InventoryItem item, RawImage image)
	{
	}

	public void OnSellClicked()
	{
	}

	private void OnSellUpdated()
	{
	}

	public void OnDeleteClicked()
	{
	}

	private void Update()
	{
	}

	public void OnDeleteConfirmation(bool affirmative, ConfirmationPopup popup)
	{
	}
}
