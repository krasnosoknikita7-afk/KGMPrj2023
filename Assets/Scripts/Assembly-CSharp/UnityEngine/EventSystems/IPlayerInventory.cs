namespace UnityEngine.EventSystems
{
	public interface IPlayerInventory : IEventSystemHandler
	{
		void Activate(UIPushOption options);

		void ActivateAtCategoryWithSlot(UIPushOption options, int categoryId, int slotPosition);

		void OpenTab(UIPushOption options, int categoryId);

		void OpenPage(UIPushOption blocking, int itemCategory, int slotsSlotCountPerPage);

		void UpdateContent();

		void SetCurrentDragTarget(GameObject draggingGameObject);

		void DragFailed();

		void ItemDataLoaded(PlayerInventoryPreviewItem itemPreview, InventoryItem inventoryItem);
	}
}
