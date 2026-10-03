using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.FirstTimeSystem
{
	public class FirstTimeGuiHandler
	{
		public void OpenTab(GameObject gameObject, int itemCategory)
		{
		}

		public void HighlightInCategoryAtSlot(GameObject gameObject, int itemCategory, int itemSlot)
		{
		}

		public void OpenPage(GameObject gameObject, int itemCategory, int slotsSlotCountPerPage)
		{
		}

		public MVWorldObjectDocumentationType? GetDocumentationType(InventorySlot slot)
		{
			return null;
		}

		public int GetItemSlot(MVWorldObjectDocumentationType docType, GameObject gameObject, int itemCategory, InventorySlots slots, int iteration)
		{
			return 0;
		}
	}
}
