using MV.Common;
using MV.WorldObject.KogamaSettings.KogamaSettingsCore.KogamaSettingTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SkillSettingBase : MonoBehaviour
{
	[SerializeField]
	private Transform imageContainer;

	[SerializeField]
	private Text nameText;

	[SerializeField]
	private Text skillCostText;

	[SerializeField]
	protected SpawnRoleSkillInfoButton infoButton;

	[SerializeField]
	private float iconHeight;

	[SerializeField]
	private float iconWidth;

	[SerializeField]
	private ColorStyle iconColor;

	[SerializeField]
	private ColorStyle iconBackgroundColor;

	private UnityAction<KogamaSettingValueWrapperBase> removeSkillCallback;

	protected KogamaSettingValueWrapperBase skillSetting;

	protected SpawnRolesSkillDataManager skillDataManager;

	protected SpawnRoleSkillIconController skillIcon;

	protected UnityAction<KogamaSettingValueWrapperBase> updateSkillCallback;

	protected UnityAction cantUpdateSkillCallback;

	protected UnityAction cantRemoveSkillCallback;

	protected int currentSkillCost;

	private int spawnRoleCost;

	private GamePassTier spawnRoleTier;

	public virtual void Initialize(string skill, SpawnRolesSkillDataManager skillDataManager, int skillCost, int spawnRoleCost, GamePassTier spawnRoleTier, KogamaSettingValueWrapperBase skillSetting, UnityAction<KogamaSettingValueWrapperBase> removeSkillCallback, UnityAction<KogamaSettingValueWrapperBase> updateSkillCallback, UnityAction cantUpdateSkillCallback, UnityAction cantRemoveSkillCallback)
	{
	}

	public void RemoveSkill()
	{
	}

	public void UpdateSpawnRoleCost(int newSpawnRoleCost)
	{
	}

	public void UpdateSpawnRoleTier(GamePassTier newTier)
	{
	}

	protected virtual void UpdateSkillData(object newValue)
	{
	}

	protected void UpdateSkillCost()
	{
	}

	protected bool CanUpdateSkill(int newSkillCost)
	{
		return false;
	}

	protected bool CanRemoveSkill()
	{
		return false;
	}

	protected virtual void InitializeInfoButton(string skill, int skillCost, SpawnRolesSkillDataManager skillDataManager)
	{
	}
}
