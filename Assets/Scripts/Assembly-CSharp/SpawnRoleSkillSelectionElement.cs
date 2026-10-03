using MV.Common;
using MV.WorldObject.KogamaSettings.KogamaSettingsCore.KogamaSettingTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SpawnRoleSkillSelectionElement : MonoBehaviour
{
	[SerializeField]
	private Transform imageContainer;

	[SerializeField]
	private Text nameText;

	[SerializeField]
	private Text spawnRoleCostText;

	[SerializeField]
	private SpawnRoleSkillInfoButton infoButton;

	[SerializeField]
	private GameObject cogWheelIcon;

	[SerializeField]
	private float iconHeight;

	[SerializeField]
	private float iconWidth;

	[SerializeField]
	private ColorStyle iconColor;

	[SerializeField]
	private ColorStyle iconBackgroundColor;

	private int skillCost;

	private int spawnRoleCost;

	private GamePassTier spawnRoleTier;

	private KogamaSettingValueWrapperBase skillSetting;

	private UnityAction<KogamaSettingValueWrapperBase> addSkillCallback;

	private UnityAction cantAddSkillCallback;

	public void Initialize(string skill, SpawnRolesSkillDataManager skillDataManager, int skillCost, int spawnRoleCost, GamePassTier spawnRoleTier, KogamaSettingValueWrapperBase skillSetting, UnityAction<KogamaSettingValueWrapperBase> addSkillCallback, UnityAction cantAddSkillCallback)
	{
	}

	public void AddSkill()
	{
	}

	private void InitializeInfoButton(string skill, SpawnRolesSkillDataManager skillDataManager)
	{
	}

	private bool CanAddSkill()
	{
		return false;
	}
}
