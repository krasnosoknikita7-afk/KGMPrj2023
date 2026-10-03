using UnityEngine;
using UnityEngine.UI;

public class AvatarShopPreviewItem : MonoBehaviour
{
	[SerializeField]
	private int previewWidth;

	[SerializeField]
	private int previewHeight;

	[SerializeField]
	private RawImage previewImage;

	[SerializeField]
	private AvatarRepositoryItem item;

	[SerializeField]
	private AvatarPurchasePopup popup;

	[SerializeField]
	private AvatarPreviewer previewer;

	public void InitializeObjectPreview(AvatarRepositoryItem item, MVWorldObjectClient wo, Transform previewItemsRoot)
	{
	}

	public void SlotPressed()
	{
	}

	public void Update()
	{
	}
}
