using UnityEngine;

public class SpawnRoleSkillInfoButton : MonoBehaviour
{
	[SerializeField]
	private GamePassesTextBubble infoTextBubble;

	private string skillType;

	private SpawnRolesSkillDataManager skillDataManager;

	private object skillValue;

	private int skillCost;

	public void Initialize(string skillType, object skillValue, int skillCost, SpawnRolesSkillDataManager skillDataManager)
	{
	}

	public void UpdateSkillValue(object skillValue)
	{
	}

	public void UpdateSkillCost(int skillCost)
	{
	}

	public void ShowInfo()
	{
	}
}
