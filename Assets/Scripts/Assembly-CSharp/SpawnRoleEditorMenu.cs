using MV.Common;
using MV.WorldObject;
using MV.WorldObject.KogamaSettings.SpecializedSettingsTypes.AttributeSettings;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRoleEditorMenu : MonoBehaviour
{
	[SerializeField]
	private Image TeamImage;

	[SerializeField]
	private Text spawnRoleCostText;

	[SerializeField]
	private SpawnRoleTierEditorMenu tierEditorMenu;

	[SerializeField]
	private SpawnRoleTeamEditor teamEditorPrefab;

	[SerializeField]
	private SpawnRoleLooksEditorMenu looksEditorMenuPrefab;

	[SerializeField]
	private SpawnRoleSkillsEditor skillsEditorMenuPrefab;

	private int spawnRoleWoId;

	private MVAvatarSpawnRoleCreator spawnRole;

	private AttributeSettingsManager spawnRoleAttributeSettingsManager;

	private SpawnRoleSkillsEditor skillsEditorMenu;

	private float timeUntilEnterPlayMode;

	public void OnTeamEditPressed()
	{
	}

	public void OnLooksEditPressed()
	{
	}

	public void OnSkillsEditPressed()
	{
	}

	public void OnEnterPlayMode()
	{
	}

	public void Initialize(int spawnRoleWoId)
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FocusCameraOnSpawnRole()
	{
	}

	private Vector3 CalculatePreviewOffset(MVWorldObjectClient spawnRole)
	{
		return default;
	}

	private void UpdateSpawnRoleCost()
	{
	}

	private int CalculateSpawnRoleCost()
	{
		return 0;
	}

	private void OnDestroy()
	{
	}

	private void OnChangeTeam(MVTeam newTeam)
	{
	}

	private void ChangeTeamImageColor(MVTeam team)
	{
	}

	private void OnChangeTier(GamePassTier newTier)
	{
	}
}
