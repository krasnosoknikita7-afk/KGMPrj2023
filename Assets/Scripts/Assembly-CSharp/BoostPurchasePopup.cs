using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BoostPurchasePopup : MonoBehaviour
{
	[Serializable]
	private struct BoosterDef
	{
		public BoostType type;

		public GameObject iconPrefab;
	}

	[SerializeField]
	private Text headerText;

	[SerializeField]
	private Text priceText;

	[SerializeField]
	private RectTransform boostImageParent;

	[SerializeField]
	private List<BoosterDef> boosterList;

	private string boostKey;

	private int price;

	private UnityAction OnPurchaseSuccessful;

	public void Initialize(BoostType boostType, string boostKey, string boostName, int price, UnityAction OnPurchaseSuccessful)
	{
	}

	public void Purchase()
	{
	}

	private void ProductPurchaseResponseHandler(int returnCode, Dictionary<object, object> purchaseResponseData)
	{
	}

	private void HandleSuccessfulPurchase()
	{
	}

	private void CreateBoostImage(BoostType boostType)
	{
	}
}
