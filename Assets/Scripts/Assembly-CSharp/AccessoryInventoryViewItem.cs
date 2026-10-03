using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.WorldObjectTypes.Avatar.Accessories;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

public class AccessoryInventoryViewItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[CompilerGenerated]
	private sealed class _003COnAndroidEndHoverEvent_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccessoryInventoryViewItem _003C_003E4__this;

		private float _003CandroidStartTime_003E5__2;

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
		public _003COnAndroidEndHoverEvent_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003COnHoverEvent_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccessoryInventoryViewItem _003C_003E4__this;

		public float sizeOffset;

		private float _003CstartTime_003E5__2;

		private Vector2 _003CstartSize_003E5__3;

		private Vector2 _003CtargetSize_003E5__4;

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
		public _003COnHoverEvent_003Ed__43(int _003C_003E1__state)
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

	private bool locked;

	[SerializeField]
	private RectTransform previewImage;

	[SerializeField]
	private StreamedSpriteToImageManual previewImageStreaminAssetManual;

	[SerializeField]
	private GameObject loadingWheel;

	[SerializeField]
	private AccessoryItemBackground accessoryItemBackground;

	[SerializeField]
	private Button purchasePopupButton;

	[SerializeField]
	private AvatarAccessoryPurchasePopup purchasePopupPrefab;

	[SerializeField]
	private Toggle equipCheckbox;

	[SerializeField]
	private GameObject priceDisplay;

	[SerializeField]
	private Text priceText;

	[SerializeField]
	private GameObject priceStrikeout;

	[SerializeField]
	private Text priceStrikeoutText;

	[SerializeField]
	private AccessoryPreviewer accessoryPreviewerPrefab;

	[SerializeField]
	private GameObject discount;

	[SerializeField]
	private Text discountText;

	[SerializeField]
	private GameObject freeLabel;

	[SerializeField]
	private GameObject newAccessoryImage;

	[SerializeField]
	private GameObject redDotNotification;

	[SerializeField]
	private RawImage levelRequirement;

	[SerializeField]
	private AccessoryTimeLimitDisplayer timeLimitDisplayer;

	private Transform rootTransform;

	private AccessoryLoader accessoryLoader;

	private MVBody targetBody;

	private AccessoryDataClient accessoryDataClient;

	private Texture2D levelRequirementTextureAsset;

	private int highlightId;

	private bool bundleView;

	private bool wasDestroyed;

	private float effectDuration;

	public void Initialize(AccessoryDataClient accessoryDataClient, Transform rootTransform, MVBody targetBody, bool bundleView = false)
	{
	}

	private void SetLevelBadge()
	{
	}

	private void OnLevelRequirementLoaded(UnityWebRequest www)
	{
	}

	public void OnClicked()
	{
	}

	public void OnEquip(bool onEquip)
	{
	}

	private void UnequipAccessoryCallback()
	{
	}

	private void OnPurchasePopupPop()
	{
	}

	private void OnDestroy()
	{
	}

	private void AccessoryCreatedCallback(AvatarAccessory avatarAccessory)
	{
	}

	private void OnPreviewImageDownloadFinished()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[IteratorStateMachine(typeof(_003COnAndroidEndHoverEvent_003Ed__41))]
	private IEnumerator OnAndroidEndHoverEvent()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnHoverEvent_003Ed__43))]
	private IEnumerator OnHoverEvent(float sizeOffset)
	{
		return null;
	}
}
