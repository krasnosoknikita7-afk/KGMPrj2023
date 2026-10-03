using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AccessoryPreviewPopup : MonoBehaviour, IAccessoryClicked, IEventSystemHandler
{
	[SerializeField]
	private AccessoryInventoryViewItem accessoryPopupItemPrefab;

	[SerializeField]
	private HorizontalLayoutGroup layoutGroup;

	private Transform tempTransform;

	private MVBody body;

	public void Initialize(List<AccessoryDataClient> previewedAccessories)
	{
	}

	private void SetBody(MVBody avatarBody)
	{
	}

	public void OpenAccessoryManagementScreen(AccessoryDataClient accessoryData)
	{
	}

	public void DisplayCategoryFeatures(AccessoryCategoryClient category)
	{
	}

	public void OpenCategoryScreen(bool canSortByInventory)
	{
	}

	public void UpdateHighlightedTab(AccessoryCategoryClient category)
	{
	}

	private void OnDestroy()
	{
	}
}
