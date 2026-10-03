using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class TeamMenu : LobbyFlowMenu
{
	[SerializeField]
	private VerticalLayoutGroup teamLayoutGroup;

	[SerializeField]
	private TeamSelectButton teamPrefab;

	[SerializeField]
	private GameObject backButton;

	protected override LobbyFlowMenuType MenuType => LobbyFlowMenuType.LobbyState;

	public override void Start()
	{
	}

	public void UpdateBackButtonVisibility()
	{
	}

	private void Update()
	{
	}

	private void OnTeamSelected(MVTeam selectedTeam)
	{
	}

	protected override bool CanShowSpawnRoleSelect()
	{
		return false;
	}

	private bool CanSpawnAsSelectedClass()
	{
		return false;
	}

	protected override void StartPlaying()
	{
	}
}
