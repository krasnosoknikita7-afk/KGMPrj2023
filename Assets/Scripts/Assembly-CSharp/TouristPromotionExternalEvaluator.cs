using System.Collections.Generic;
using UnityEngine;

public class TouristPromotionExternalEvaluator : MonoBehaviour
{
	private class TouristPromotionExternalDef
	{
		public TouristPromotion Promotion { get; private set; }

		public int FrequencyPercent { get; private set; }

		public TouristPromotionExternalDef(TouristPromotion promotion, int frequencyPercent)
		{
		}
	}

	[SerializeField]
	private TouristPromotion creyGamesPrefab;

	[SerializeField]
	private TouristPromotion customPromotionPrefab;

	private List<TouristPromotionExternalDef> availablePromotions;

	public void Start()
	{
	}

	public bool TryGetExternalPromotion(out TouristPromotion externalPromotion)
	{
		externalPromotion = null;
		return false;
	}
}
