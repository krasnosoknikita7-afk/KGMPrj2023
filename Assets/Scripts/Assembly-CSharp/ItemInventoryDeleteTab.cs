using UnityEngine;
using UnityEngine.UI;

public class ItemInventoryDeleteTab : ManageItemPage
{
	[SerializeField]
	private Text itemName;

	[SerializeField]
	private RawImage preview;

	private InventoryItem previewedItem;

	public override void Initialize(RawImage image, InventoryItem item)
	{
	}

	public void OnRemoveFromInventory()
	{
	}

	public void OnConfirmation(bool affirmative, ConfirmationPopup popup)
	{
	}
}
