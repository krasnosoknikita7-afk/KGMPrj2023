using System;
using Assets.Scripts.WorldObjectTypes.Avatar.Accessories;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class AccessoryView : MonoBehaviour
{
	private AccessoryDataClient accessoryDataClient;

	[SerializeField]
	private Image previewImage;

	[SerializeField]
	private StreamedSpriteToImageManual previewImageStreamingManager;

	[SerializeField]
	private Text nameText;

	[SerializeField]
	private Button purchaseButton;

	[SerializeField]
	private Text priceText;

	[SerializeField]
	private Text priceTextWithoutDiscount;

	[SerializeField]
	private Text originalPriceText;

	[SerializeField]
	private GameObject discountTag;

	[SerializeField]
	private Text discountTagText;

	[SerializeField]
	private Text goldSavedText;

	[SerializeField]
	private AccessoryOffsetSlider offsetSlider;

	[SerializeField]
	private AccessorySizeSlider sizeSlider;

	[SerializeField]
	private AccessoryItemBackground accessoryItemBackground;

	[SerializeField]
	private AccessoryTimeLimitDisplayer timeLimitDisplayer;

	[SerializeField]
	private RawImage levelRequirementPurchaseButton;

	[SerializeField]
	private GameObject newAccessoryImage;

	[SerializeField]
	private TabMenuAccessoryShop tabMenu;

	[SerializeField]
	private AvatarAccessoryPurchasePopup AvatarAccessoryPurchasePopupPrefab;

	[SerializeField]
	private AccessoryPreviewer accessoryPreviewerPrefab;

	[SerializeField]
	private PlayerCurrentGoldAmountTracker currentGoldAmountTracker;

	[SerializeField]
	private AvatarAccessoryEquipPopup avatarAccessoryEquipPopup;

	[SerializeField]
	private AvatarAccessoryErrorPopup insufficientResourcePopup;

	[SerializeField]
	private LevelErrorPopup insufficientLevelPopup;

	[SerializeField]
	private GameObject shopCloseButton;

	[SerializeField]
	private GameObject loadingWheel;

	[SerializeField]
	private GameObject emptyFrame;

	[SerializeField]
	private Text claimText;

	[SerializeField]
	private AvatarAccessoryErrorPopup touristErrorPopup;

	[SerializeField]
	private AccessoryShinyButton buttonAnimation;

	[SerializeField]
	private GameObject lockIcon;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private AccessoryPreviewer previewer;

	private Transform rootTransform;

	private AccessoryLoader accessoryLoader;

	private Action OnFinished;

	private bool isPreviewing;

	private MVBody avatarBody;

	private string previewImageUrl;

	public void Initialize(AccessoryDataClient accessoryData)
	{
	}

	public bool CurrentlyViewingAccessory(AccessoryDataClient data)
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void HandlePreviewing(MVBody avatarBody)
	{
	}

	private void OnLevelRequirementLoaded(UnityWebRequest www)
	{
	}

	public void Destroy()
	{
	}

	public void Pop()
	{
	}

	public void OnPurchaseButtonPressed()
	{
	}

	public void Purchase()
	{
	}

	private void OnGoldPurchaseDialogResult(bool result)
	{
	}

	public void BackToShop()
	{
	}

	private void DestroyFeaturedTab()
	{
	}

	private void EquipPopupResultCallback()
	{
	}

	private void AvatarAccessoryCreateHandler(AvatarAccessory avatarAccessory)
	{
	}

	private void OnPreviewImageFinishedDownloading()
	{
	}

	private void HandlePrices(AccessoryDataClient streamingAssetInfo)
	{
	}

	private void SetShowPrices(bool shouldShow)
	{
	}

	private void HandleNotOwnedUI()
	{
	}

	private void HideNotLoadedStreamingAssetsObject()
	{
	}

	private void ShowLoadedStreamingAssetsObject()
	{
	}

	private void SetShowNotOwnedUI(bool shouldShow)
	{
	}

	private void OnTouristSignupClicked(bool confirmed)
	{
	}
}
