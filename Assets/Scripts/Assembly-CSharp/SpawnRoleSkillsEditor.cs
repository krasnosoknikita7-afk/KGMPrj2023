using System.Collections.Generic;
using MV.Common;
using MV.WorldObject.KogamaSettings.KogamaSettingsCore.KogamaSettingTypes;
using MV.WorldObject.KogamaSettings.SpecializedSettingsTypes.AttributeSettings;
using UnityEngine;
using UnityEngine.Events;

public class SpawnRoleSkillsEditor : MonoBehaviour
{
	[SerializeField]
	private Transform defenceSkillsContainer;

	[SerializeField]
	private Transform offenceSkillsContainer;

	[SerializeField]
	private Transform tacticalSkillsContainer;

	[SerializeField]
	private GamePassesTextBubble cantAddSkillInfoTextBubble;

	[SerializeField]
	private SpawnRolesSkillDataManager skillDataManagerPrefab;

	[SerializeField]
	private SpawnRoleSkillSelectionMenu skillSelectionMenuPrefab;

	private AttributeSettingsManager attributeSettingsManager;

	private int spawnRoleCost;

	private GamePassTier spawnRoleTier;

	private List<SkillSettingBase> skillSettingList;

	private UnityAction updateSkillCostCallback;

	private void OnDestroy()
	{
	}

	public void Initialize(int spawnRoleCost, GamePassTier spawnRoleTier, AttributeSettingsManager spawnRoleAttributeSettingsManager, UnityAction updateSkillCost)
	{
	}

	public void UpdateSpawnRoleTier(GamePassTier newSpawnRoleTier)
	{
	}

	public void UpdateSpawnRoleCost(int newSpawnRoleCost)
	{
	}

	private void CreateSkillSettings()
	{
	}

	private void CreateSkillSetting(string skillKey, KogamaSettingWrapperBase skillSettingData)
	{
	}

	public void OnAddDefenceSkillPressed()
	{
	}

	public void OnAddOffenceSkillPressed()
	{
	}

	public void OnAddTacticalSkillPressed()
	{
	}

	private void AddSkillCallback(KogamaSettingValueWrapperBase attributeSetting)
	{
	}

	private void CantAddSkillCallback()
	{
	}

	private void CantUpdateSkillCallback()
	{
	}

	private void CantRemoveSkillCallback()
	{
	}

	private void ShowPowerErrorTipBubble()
	{
	}

	private void RemoveSkillCallback(KogamaSettingValueWrapperBase attributeSetting)
	{
	}

	private void UpdateSkillCallback(KogamaSettingValueWrapperBase attributeSetting)
	{
	}
}
