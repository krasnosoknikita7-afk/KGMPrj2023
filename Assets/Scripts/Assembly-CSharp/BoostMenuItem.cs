using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostMenuItem : MonoBehaviour
{
	[Serializable]
	private struct BoosterDef
	{
		public BoostType type;

		public GameObject iconPrefab;
	}

	[SerializeField]
	private GameObject boostUnlockedGlow;

	[SerializeField]
	private GameObject boostActiveUI;

	[SerializeField]
	private RectTransform boostActiveIcon;

	[SerializeField]
	private NotificationFade boostActiveIconFader;

	[SerializeField]
	private CanvasGroup boostActiveIconCanvasGroup;

	[SerializeField]
	private RectTransform boostTypeImageParent;

	[SerializeField]
	private Button getWithAdOrSubscriptionButton;

	[SerializeField]
	private GameObject buttonIcon;

	[SerializeField]
	private Button getWithAdDisabled;

	[SerializeField]
	private Button getWithGold;

	[SerializeField]
	private Text boostDescription;

	[SerializeField]
	private Text timeLeftText;

	[SerializeField]
	private Text priceText;

	[SerializeField]
	private BoostPurchasePopup purchasePopupPrefab;

	[SerializeField]
	private GameObject boostTouristInformation;

	[SerializeField]
	private List<BoosterDef> boosterList;

	[SerializeField]
	private BoostImageController boostImageController;

	[SerializeField]
	private AnimationCurve activeIconScaleEffect;

	[SerializeField]
	private float activeIconScaleEffectDuration;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private float activeIconScaleEffectStartTime;

	private Boost boost;

	private int price;

	public void Initialize(Boost boost, bool boostUnlocked)
	{
	}

	private void Update()
	{
	}

	private void SetBoostUIUnlocked(bool boostUnlocked)
	{
	}

	private void ActivateActiveBoostIconEffect()
	{
	}

	public void OnUnlockBoostWithSubscriptionClicked()
	{
	}

	public void OnUnlockBoostWithAdClicked()
	{
	}

	public void OnPurchaseBoostPressed()
	{
	}

	private int GetBoostPrice()
	{
		return 0;
	}

	private void SetBoostActive(bool isBoostActive)
	{
	}

	private void BoostChanged()
	{
	}

	private void BoostUnlockedResponse(bool boostUnlocked)
	{
	}

	private void OnPurchaseSuccessful()
	{
	}

	private void OnDestroy()
	{
	}
}
