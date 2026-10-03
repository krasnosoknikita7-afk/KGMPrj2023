using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class AccessoryShopController : MonoBehaviour, IInventoryChanged, IEventSystemHandler, IAttachToBody, IAccessoryInventoryControl
{
	[CompilerGenerated]
	private sealed class _003COpenAccessoryViewDelayed_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccessoryShopController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003COpenAccessoryViewDelayed_003Ed__21(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private InventoryController inventoryController;

	private Transform previewItemsRoot;

	private Dictionary<int, TabState> tabs;

	private int selectedTab;

	private AccessoryAttacher accessoryAttacher;

	private int currentlyAttachingID;

	private bool attachingReady;

	private AccessoryCategoryClient startingCategory;

	private bool displayShopItems;

	[SerializeField]
	private AccessoryInventoryViewItem accessoryInventoryItemPrefab;

	[SerializeField]
	private int numberOfSlotsPrPage;

	[SerializeField]
	private InventoryController inventoryControllerPrefab;

	private AccessoryViewController accessoryViewController;

	private UIPushOption currentlyPushOption;

	private UIPushOption pushOption;

	private AccessoryDataClient accessoryDataToShow;

	private bool firstTimeSetup;

	private void Setup()
	{
	}

	public void Activate(UIPushOption pushOption)
	{
	}

	public void OpenInventoryAtItem(UIPushOption pushOption, AccessoryDataClient accessoryData)
	{
	}

	public void Activate(UIPushOption pushOption, AccessoryCategoryClient category)
	{
	}

	private void ReadyCallbackAccessoryView()
	{
	}

	[IteratorStateMachine(typeof(_003COpenAccessoryViewDelayed_003Ed__21))]
	private IEnumerator OpenAccessoryViewDelayed()
	{
		return null;
	}

	public void DisplayPurchasableItems(bool displayShopItems)
	{
	}

	public void RefreshItems()
	{
	}

	private void ReadyCallback()
	{
	}

	private void ClearShop()
	{
	}

	private void DisplayAllItems()
	{
	}

	private void AddDynamicTab(AccessoryCategoryClient category)
	{
	}

	private void CreateAndAddTab(AccessoryCategoryClient category, int highestSlotIndex)
	{
	}

	private void DisplayOwnedItems()
	{
	}

	private int GetOwnedAmount(List<AccessoryDataClient> accessoryList)
	{
		return 0;
	}

	private void SetAccessoriesToSelectable(bool selectable)
	{
	}

	public void InventoryChanged()
	{
	}

	public void ResetAfterBundlePurchase()
	{
	}

	private void PageTurned(int dir)
	{
	}

	private void TabSelected(int tabId)
	{
	}

	private void OnPop()
	{
	}

	private void UpdateContent()
	{
	}

	private void UpdateContentWithBody(MVBody avatarBody)
	{
	}

	private List<AccessoryDataClient> GetAccessoryDataFromCategoryType(AccessoryCategoryClient category)
	{
		return null;
	}

	public void AttachToBody(int productId, float offset, float scale)
	{
	}

	private void Attach(MVBody body, float offset, float scale)
	{
	}

	private void AttacherFinished()
	{
	}
}
