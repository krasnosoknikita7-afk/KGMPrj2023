using UnityEngine;
using UnityEngine.EventSystems;

public class AccessoryViewController : MonoBehaviour, IAccessoryClicked, IEventSystemHandler, IBundleController
{
	[SerializeField]
	private AvatarAccessoryPreviewer previewer;

	[SerializeField]
	private AccessoryView accessoryView;

	[SerializeField]
	private GameObject inventoryView;

	[SerializeField]
	private BundleView bundlePurchaseOptions;

	[SerializeField]
	private AccessoryShopToggleInventory backbackController;

	[SerializeField]
	private TabMenuAccessoryShop tabMenuAccessoryShop;

	[SerializeField]
	private GameObject featuredTabFlare;

	[SerializeField]
	private LevelProgressAccessoryShop levelProgress;

	[SerializeField]
	private GameObject playerGoldGameObject;

	private Color prevLight;

	private bool wasEnabled;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void UpdateHighlightedTab(AccessoryCategoryClient category)
	{
	}

	public void OpenAccessoryManagementScreen(AccessoryDataClient accessoryData)
	{
	}

	public void OpenCategoryScreen(bool canSortByInventory)
	{
	}

	public void ShowBundle()
	{
	}

	private void HideScreens()
	{
	}

	public void PurchasedBundle()
	{
	}

	public void DisplayCategoryFeatures(AccessoryCategoryClient category)
	{
	}
}
