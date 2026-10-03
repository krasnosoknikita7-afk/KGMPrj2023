using MV.Common;
using MV.WorldObject.KogamaSettings.KogamaSettingsCore.KogamaSettingTypes;
using UnityEngine;
using UnityEngine.Events;

public class SpawnRoleSkillSelectionMenu : MonoBehaviour
{
	[SerializeField]
	private Transform skillSelectionElementContainer;

	[SerializeField]
	private GameObject noSkillsText;

	[SerializeField]
	private SpawnRoleSkillSelectionElement skillSelectionElementPrefab;

	private UnityAction<KogamaSettingValueWrapperBase> addSkillCallback;

	private UnityAction cantAddSkillCallback;

	private SpawnRolesSkillDataManager skillDataManager;

	private int spawnRoleCost;

	private GamePassTier spawnRoleTier;

	public void Initialize(SpawnRolesSkillDataManager skillDataManager, KogamaSettingWrapperBase notAppliedSettings, SkillCategory skillCategory, int spawnRoleCost, GamePassTier spawnRoleTier, UnityAction<KogamaSettingValueWrapperBase> addSkillCallback, UnityAction cantAddSkillCallback)
	{
	}

	private void CreateSkillSelectionElement(string skillKey, KogamaSettingWrapperBase skillSetting)
	{
	}
}
