using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class DeathPromotionController : MonoBehaviour, IDeathPromotionSelector, IEventSystemHandler
{
	[SerializeField]
	private TouristAdController touristAdController;

	[SerializeField]
	private RegisteredPromotionController registeredAdController;

	private IPromotionController adController;

	public bool ReadyForAd => false;

	public void Initialize()
	{
	}

	public void TryShowPromotion(UnityAction<bool, bool> onPromotionPopped)
	{
	}
}
