using System;
using System.Collections.Generic;
using MV.WorldObject.KogamaSettings.SpecializedSettingsTypes.GameBoosterSettings.GameBoosterSettingTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BoostEditPopup : MonoBehaviour
{
	[Serializable]
	private struct BoosterDef
	{
		public BoostType type;

		public GameObject iconPrefab;
	}

	[SerializeField]
	private RectTransform boostImageParent;

	[SerializeField]
	private Text headerText;

	[SerializeField]
	private Slider priceSlider;

	[SerializeField]
	private InputField priceInputField;

	[SerializeField]
	private List<BoosterDef> boosterList;

	protected int originalPrice;

	protected bool isInitialized;

	protected GameBoosterSettingWithGoldSetting boostSetting;

	protected UnityAction<object> settingChangedCallback;

	protected UnityAction<int> priceChangedCallback;

	protected UnityAction submitDataCallback;

	public virtual void Initialize(Boost boost, GameBoosterSettingWithGoldSetting boostSetting, UnityAction<object> settingChangedCallback, UnityAction<int> priceChangedCallback, UnityAction submitDataCallback)
	{
	}

	public virtual void OnConfirmButtonPressed()
	{
	}

	public virtual void OnCancelBoostEdit()
	{
	}

	private void CreateBoostImage(Boost boost)
	{
	}

	private void UpdatePriceTextInputFieldWithPriceSliderValue()
	{
	}

	private void UpdatePriceSliderValueWithPriceInputFieldText()
	{
	}

	private void UpdatePriceData()
	{
	}

	public void PriceSliderValueChanged()
	{
	}

	public void PriceInputFieldChange()
	{
	}
}
