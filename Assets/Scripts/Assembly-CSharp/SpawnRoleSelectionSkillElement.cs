using MV.WorldObject.KogamaSettings.KogamaSettingsCore.KogamaSettingTypes;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRoleSelectionSkillElement : MonoBehaviour
{
	[SerializeField]
	private Transform skillIconContainer;

	[SerializeField]
	private Image powerFillImage;

	[SerializeField]
	private Image negativePowerFillImage;

	[SerializeField]
	private Text nameText;

	[SerializeField]
	private Text descriptionText;

	[SerializeField]
	private float iconHeight;

	[SerializeField]
	private float iconWidth;

	[SerializeField]
	private ColorStyle iconColor;

	[SerializeField]
	private ColorStyle iconBackgroundColor;

	public void Initialize(string skill, SpawnRolesSkillDataManager skillDataManager, KogamaSettingValueWrapperBase skillSetting)
	{
	}

	private float CalculateSkillPowerPercentage(float value, float max, float min, float zeroValue)
	{
		return 0f;
	}
}
