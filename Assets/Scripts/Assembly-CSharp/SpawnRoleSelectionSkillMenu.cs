using MV.Common;
using MV.WorldObject.KogamaSettings.KogamaSettingsCore.KogamaSettingTypes;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRoleSelectionSkillMenu : MonoBehaviour
{
	[SerializeField]
	private Transform skillElementContainer;

	[SerializeField]
	private GameObject leftBorder;

	[SerializeField]
	private GameObject noSkillsText;

	[SerializeField]
	private RawImage spawnRolePreviewImage;

	[SerializeField]
	private Text spawnRoleCost;

	[SerializeField]
	private GameObject backgroundTier1;

	[SerializeField]
	private GameObject backgroundTier2;

	[SerializeField]
	private GameObject backgroundTier3;

	[SerializeField]
	private SpawnRoleSelectionSkillElement skillElementPrefab;

	[SerializeField]
	private SpawnRolePreviewer spawnRolePreviewerPrefab;

	[SerializeField]
	private SpawnRolesSkillDataManager skillDataManagerPrefab;

	[SerializeField]
	protected int previewWidth;

	[SerializeField]
	protected int previewHeight;

	[SerializeField]
	private RectTransform contentScrollRect;

	[SerializeField]
	private RectTransform contentRectTransform;

	private SpawnRolePreviewer spawnRolePreviewer;

	public void Initialize(int spawnRoleId, GamePassTier tierRequirement, GameObject spawnRolePreviewObject)
	{
	}

	private void ChangeBackground(GamePassTier tier)
	{
	}

	private void SetupPreviewImage(GameObject spawnRolePreviewObject)
	{
	}

	private int CalculateTotalCostOfSkills(KogamaSettingsCollectionBase subSettingData)
	{
		return 0;
	}
}
