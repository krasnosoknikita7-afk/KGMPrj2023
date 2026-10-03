using Assets.Scripts.AdIntegration;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class RegisteredPromotionController : MonoBehaviour, IRegisterPromotionAdController, IEventSystemHandler, IPromotionController
{
	[SerializeField]
	private RegisteredPromotionPopup registeredPromotionPopupPrefab;

	[SerializeField]
	private RegisteredPromotionPopup registeredElitePromotionPopupPrefab;

	[SerializeField]
	private float playFromKogamaPromoInterval;

	[SerializeField]
	private float joinTheElitePromoInterval;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private float timer;

	private bool embedded;

	private bool subscriber;

	private bool showTouristPromotion;

	private float timeBeforeShownPromotion;

	private UnityAction<bool, bool> onPromotionWasPopped;

	public bool ReadyForAd => false;

	public bool IsPromotionAvailable => false;

	public void Initialize()
	{
	}

	public void ShowRegisteredPromotionAd()
	{
	}

	public void InterstitialAdResult(InterstitialAdResult obj)
	{
	}

	private void ShowRegisteredPromotionPopup()
	{
	}

	private void OnPromotionPop()
	{
	}

	private void PushPromotionSlide(RegisteredPromotionPopup popupPrefab, bool isEmbeddedPromotion)
	{
	}

	private void Update()
	{
	}

	public void ShowPromotion(UnityAction<bool, bool> onPop)
	{
	}
}
