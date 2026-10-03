using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AdIntegration.InHouse
{
	public class InHouseAdController : MonoBehaviour, IInHousePromotion, IEventSystemHandler
	{
		[SerializeField]
		private GeneralPromotionAd generalPromotionAdPrefab;

		[SerializeField]
		private PromotionLooksData touristLooksData;

		[SerializeField]
		private PromotionLooksData registeredLooksData;

		private GeneralPromotionAd generalPromotionAd;

		private Action<bool> callback;

		private bool timeoutAsEnabled;

		private int timeoutSuccessDelay;

		private const int TimeoutInterstitial = 5;

		public bool Showing { get; private set; }

		private void Awake()
		{
		}

		public void Initialize(bool timeoutEnabled, int timeoutDelay)
		{
		}

		public void ShowPromotionRewarded(Action<bool> onPromotionFinished)
		{
		}

		private void OnPromotionPopped()
		{
		}

		public void ShowPromotionInterstitial(Action<bool> onPromotionFinished)
		{
		}

		private void ShowInHouseAd(Action<bool> onPromotionFinished, int timeout)
		{
		}

		public void Pop()
		{
		}
	}
}
