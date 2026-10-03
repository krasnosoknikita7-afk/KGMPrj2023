using MV.WorldObject.KogamaSettings.SpecializedSettingsTypes.GameBoosterSettings.GameBoosterSettingTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BoostEditIntPopup : BoostEditPopup
{
	[SerializeField]
	private Text boostSliderDescription;

	[SerializeField]
	private Slider boostSlider;

	[SerializeField]
	private InputField boostInputField;

	private int originalSettingValue;

	public override void Initialize(Boost boost, GameBoosterSettingWithGoldSetting boostSetting, UnityAction<object> settingChangedCallback, UnityAction<int> priceChangedCallback, UnityAction submitDataCallback)
	{
	}

	public override void OnCancelBoostEdit()
	{
	}

	private void UpdateBoostTextInputFieldWithBoostSliderValue()
	{
	}

	private void UpdateBoostSliderValueWithBoostInputFieldText()
	{
	}

	private void UpdateSettingData()
	{
	}

	public void BoostSliderValueChanged()
	{
	}

	public void BoostInputFieldChange()
	{
	}
}
