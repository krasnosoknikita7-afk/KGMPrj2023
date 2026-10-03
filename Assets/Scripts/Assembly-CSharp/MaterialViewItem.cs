using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MaterialViewItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private byte id;

	private bool locked;

	private bool isAvailable;

	[SerializeField]
	private Image lockedImage;

	[SerializeField]
	private RawImage buttonImage;

	[SerializeField]
	private MaterialPurchasePopup materialPurchasePopupPrefab;

	[SerializeField]
	private float unavailableAlpha;

	[SerializeField]
	private Image selectedBackground;

	[SerializeField]
	private ToolTip toolTip;

	[SerializeField]
	private GameObject mouseHoverDescriptionFrame;

	public void Initialize(byte id, bool locked, Texture2D texture2D, bool isAvailable, bool isSelected)
	{
	}

	public void OnClick()
	{
	}

	private void PurchaseCallback(bool success, Dictionary<object, object> purchaseData)
	{
	}

	public void OnInfoClick()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
