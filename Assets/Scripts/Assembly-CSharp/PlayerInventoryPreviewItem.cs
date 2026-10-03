using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerInventoryPreviewItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDownloadImage_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public PlayerInventoryPreviewItem _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CDownloadImage_003Ed__22(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CAddToWorldInSeconds_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int seconds;

		public PlayerInventoryPreviewItem _003C_003E4__this;

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
		public _003CAddToWorldInSeconds_003Ed__33(int _003C_003E1__state)
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

	[SerializeField]
	private RawImage previewImage;

	[SerializeField]
	private int previewWidth;

	[SerializeField]
	private int previewHeight;

	[SerializeField]
	private InventoryItemDragHandler dragHandler;

	[SerializeField]
	private PlayerInventoryItemManager itemManagerPrefab;

	[SerializeField]
	private InventoryItemMetaData metaData;

	[SerializeField]
	private InventoryItemPreviewer objectPreviewerPrefab;

	[SerializeField]
	private InventoryItemPreview itemPreviewerPrefab;

	[SerializeField]
	private InventoryItemCubeModelHandler itemPreviewerCubeModelPrefab;

	[SerializeField]
	private ToolTip toolTip;

	[SerializeField]
	private GameObject padLock;

	[SerializeField]
	private ItemPurchasePopup popup;

	[SerializeField]
	private Text text;

	[SerializeField]
	private Texture noImageTexture;

	[SerializeField]
	private Image loadingWheel;

	private InventoryItem item;

	private InventoryItemPreviewer objectPreviewer;

	private bool initialized;

	private bool hasItemPreviewer;

	private bool requiresUnlocking;

	public MVWorldObjectDocumentationType DocumentationType;

	public void Initialize(Transform rootTransform, InventoryItem invItem, bool draggable, bool done)
	{
	}

	[IteratorStateMachine(typeof(_003CDownloadImage_003Ed__22))]
	private IEnumerator DownloadImage(string url)
	{
		return null;
	}

	public void Initialize(Transform rootTransform, InventoryItem invItem, MVWorldObjectClient woPreviewObject, bool draggable)
	{
	}

	public void LoadItemPreviewer(Transform rootTransform, InventoryItem item, MVWorldObjectClient woPreviewObject)
	{
	}

	private void OnDestroy()
	{
	}

	public InventoryItemPreviewer GetPreviewer()
	{
		return null;
	}

	public InventoryItem GetItem()
	{
		return null;
	}

	public void AdditionalItemSettingsPressed()
	{
	}

	public void SlotPressed()
	{
	}

	private void OnInventoryItemFailedToLoad()
	{
	}

	private void AddItemToWorldFromInventory()
	{
	}

	private void OnInventoryItemLoaded(object sender, ReceivedItemFromQueryEventArgs e)
	{
	}

	[IteratorStateMachine(typeof(_003CAddToWorldInSeconds_003Ed__33))]
	private IEnumerator AddToWorldInSeconds(int seconds)
	{
		return null;
	}

	public void ShowPurchasePopUp()
	{
	}

	public void Update()
	{
	}
}
