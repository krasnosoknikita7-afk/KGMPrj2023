using AdIntegration.InHouse;
using Assets.Scripts.AdIntegration;
using MV.Common;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class TouristAdController : MonoBehaviour, ITouristAdController, IEventSystemHandler, IPromotionController
{
	[SerializeField]
	private GeneralPromotionAd generalPromotionPrefab;

	[SerializeField]
	private PromotionLooksData touristLooksData;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	[SerializeField]
	private TouristPromotionExternalEvaluator touristPromotionExternalEvaluator;

	[SerializeField]
	private float timeBeforeAdShown;

	private float timer;

	private UnityAction<bool, bool> onPromotionWasPopped;

	private bool eligibleForPromotion;

	private bool withAd;

	public bool ReadyForAd => false;

	public bool IsPromotionAvailable => false;

	public void Initialize()
	{
	}

	private void OnChangeMode(SpawnRoleModeType type)
	{
	}

	private void OnPromotionPopped()
	{
	}

	public void ShowPromotion(UnityAction<bool, bool> onPop)
	{
	}

	private void ShowAdWithoutPromotion(InterstitialAdResult obj)
	{
	}

	private static bool TouristPromotionAllowed()
	{
		return false;
	}

	public void ShowAd()
	{
	}

	private void InterstitialAdResult(InterstitialAdResult obj)
	{
	}

	private void Update()
	{
	}
}
