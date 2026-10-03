using MV.Common;
using MV.WorldObject.KogamaSettings.KogamaSettingsCore.KogamaSettingTypes;
using MV.WorldObject.KogamaSettings.SpecializedSettingsTypes.AttributeSettings.AttributeSettingTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SkillSettingFloat : SkillSettingBase
{
	[SerializeField]
	private Slider slider;

	[SerializeField]
	private InputField inputField;

	private bool isInitialized;

	private float settingValue;

	private AttributeSettingFloat skillPercentageSetting;

	public override void Initialize(string skill, SpawnRolesSkillDataManager skillDataManager, int skillCost, int spawnRoleCost, GamePassTier spawnRoleTier, KogamaSettingValueWrapperBase skillSetting, UnityAction<KogamaSettingValueWrapperBase> removeSkillCallback, UnityAction<KogamaSettingValueWrapperBase> updateSkillCallback, UnityAction cantUpdateSkillCallback, UnityAction cantRemoveSkillCallback)
	{
	}

	protected override void InitializeInfoButton(string skill, int skillCost, SpawnRolesSkillDataManager skillDataManager)
	{
	}

	protected override void UpdateSkillData(object newValue)
	{
	}

	private void UpdateTextInputFieldWithSliderValue()
	{
	}

	private void UpdateSliderValueWithInputFieldText()
	{
	}

	public void SliderValueChanged()
	{
	}

	public void InputFieldChange()
	{
	}
}
