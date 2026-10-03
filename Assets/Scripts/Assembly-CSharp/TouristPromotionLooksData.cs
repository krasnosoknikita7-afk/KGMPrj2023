using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouristPromotionLooksData : MonoBehaviour
{
	[Serializable]
	private struct PromotionLooksData
	{
		public Image PromotionImage;

		public string PromotionText;

		public bool ValidOnKogamaPortal;

		public bool ValidOnAnonymousExternalPortal;
	}

	[SerializeField]
	private List<PromotionLooksData> promotionData;

	private int promotionIndex;

	private bool initialized;

	private List<int> portalsIndices;

	private List<int> embeddedIndices;

	public void RandomizePromotion(bool embedded)
	{
	}

	public Image GetPromotionImage()
	{
		return null;
	}

	public string GetPromotionText()
	{
		return null;
	}
}
