using UnityEngine;
using UnityEngine.EventSystems;

public class AvatarShopController : MonoBehaviour, IPurchaseAvatar, IEventSystemHandler
{
	private InventoryController inventoryController;

	private TabState tab;

	[SerializeField]
	private int numberOfSlotsPrPage;

	[SerializeField]
	private InventoryController inventoryControllerPrefab;

	[SerializeField]
	private AvatarShopPreviewItem previewItemPrefab;

	private Transform previewRootTransform;

	private AvatarEditModeBodyController avatarEditModeBodyController;

	private AvatarRepository avatarRepository;

	public void Initialize(AvatarEditModeBodyController editModeBodyController)
	{
	}

	private static MVWorldObjectClient GetWorldObjectFromItemData(AvatarRepositoryItem item)
	{
		return null;
	}

	public void Activate(UIPushOption pushOption)
	{
	}

	private void UpdateContent()
	{
	}

	private void AddPreviewObjectForIndex(int index)
	{
	}

	private void OnPop()
	{
	}

	public void PageTurned(int dir)
	{
	}

	public void PurchaseAvatar(AvatarRepositoryItem item)
	{
	}
}
