using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace AdIntegration.InHouse
{
	public class PromotionLooksData : MonoBehaviour
	{
		[Serializable]
		private struct LooksData
		{
			public Image promotionImage;

			public string promotionText;

			public bool validOnKogamaPortal;

			public bool validOnAnonymousExternalPortal;

			[FormerlySerializedAs("inHouseActionType")]
			public PromotionActionType promotionActionType;
		}

		[SerializeField]
		private List<LooksData> promotionData;

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

		public PromotionActionType GetActionType()
		{
			return PromotionActionType.GoldPurchase;
		}

		public string GetActionText(PromotionActionType promotionActionType)
		{
			return null;
		}
	}
}
