using System;
using UnityEngine.EventSystems;

namespace AdIntegration.InHouse
{
	public interface IInHousePromotion : IEventSystemHandler
	{
		void ShowPromotionRewarded(Action<bool> onPromotionFinished);

		void ShowPromotionInterstitial(Action<bool> onPromotionFinished);
	}
}
