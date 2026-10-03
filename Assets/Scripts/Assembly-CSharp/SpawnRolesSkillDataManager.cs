using System;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRolesSkillDataManager : MonoBehaviour
{
	[Serializable]
	public struct SkillData
	{
		public string type;

		public string name;

		public string description;

		public SpawnRoleSkillIconController iconPrefab;

		public SkillSettingBase settingsPrefab;

		public float zeroValue;
	}

	[SerializeField]
	private List<SkillData> skillDataList;

	[SerializeField]
	private List<string> defenceSkillsList;

	[SerializeField]
	private List<string> offenceSkillsList;

	[SerializeField]
	private List<string> tacticalSkillsList;

	public SpawnRoleSkillIconController GetImageClone(string skillType, ColorStyle iconColorStyle = ColorStyle.Gray, ColorStyle iconBackgroundColorStyle = ColorStyle.OffWhite, float imageWidth = 256f, float imageHeight = 256f)
	{
		return null;
	}

	public string GetNameText(string skillType)
	{
		return null;
	}

	public SkillSettingBase GetSkillsSettingsClone(string skillType)
	{
		return null;
	}

	public SkillCategory GetSkillsCategory(string skillKey)
	{
		return SkillCategory.Defence;
	}

	public string GetSkillDescription(string skillType, object settingValue, int skillCost)
	{
		return null;
	}

	public float GetZeroValue(string skillType)
	{
		return 0f;
	}

	public static Color GetCostColor(int skillCost)
	{
		return default;
	}

	private Color GetValueColor(int skillCost)
	{
		return default;
	}
}
