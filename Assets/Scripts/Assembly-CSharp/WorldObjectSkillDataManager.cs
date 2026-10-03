using MV.WorldObject.KogamaSettings.KogamaSettingsCore.KogamaSettingTypes;

public class WorldObjectSkillDataManager
{
	private KogamaSettingsCollectionBase skillData;

	public void Initialize(KogamaSettingWrapperBase settings)
	{
	}

	public bool HasSkill(string skillKey)
	{
		return false;
	}

	public float GetSkillFloatValue(string skillKey)
	{
		return 0f;
	}

	public int GetSkillIntValue(string skillKey)
	{
		return 0;
	}
}
