using MV.WorldObject;

public class ESWaitForPlayModeAvatar : ESStateBase
{
	private enum EnterPlayFromEditSpawnState
	{
		DefaultSpawnAsSpawnRole = 0,
		SpawnAsDefaultAvatar = 1,
		SpawnAsSelectedSpawnRole = 2
	}

	private bool defaultPlayModeSpawnRoleReady;

	private MVTeam selectedTeam;

	public override void Enter(EditorStateMachine esm)
	{
	}

	private void SpawnRolesManagerOnOnSpawnRoleActivated(int spawnRoleId)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	public override void Exit(EditorStateMachine esm)
	{
	}

	private EnterPlayFromEditSpawnState CalculateEnterPlayFromEditState()
	{
		return EnterPlayFromEditSpawnState.DefaultSpawnAsSpawnRole;
	}

	private bool IsTeamWithoutSpawnRole(bool teamsPresent, bool isTeamValid)
	{
		return false;
	}

	private bool IsSelectedSpawnRoleDeleted(bool isSpawnRoleValid, int selectedSpawnRoleCreatorId)
	{
		return false;
	}

	private bool ShouldEnterAsDefaultSpawnRole(bool isSpawnRoleValid, bool teamsPresent, int numberOfSpawnPoints)
	{
		return false;
	}

	private bool ShouldEnterAsSelectedSpawnRole(bool isSpawnRoleValid, bool spawnRolesPresent)
	{
		return false;
	}

	private void HandleEnterPlayModeFromEditSpawn(EnterPlayFromEditSpawnState enterSpawnState)
	{
	}

	private void HandleDefaultSpawnAsSpawnRole()
	{
	}

	private void HandleSpawnAsDefaultPlayModeSpawnRole()
	{
	}

	private void HanldeSpawnAsSelectedSpawnRole()
	{
	}

	private void SpawnAsSelectedSpawnRole(int spawnRoleId)
	{
	}

	private void SpawnAsDefaultPlayModeSpawnRole()
	{
	}

	private bool CanSpawnAsSelectedSpawnRole(int spawnRoleId)
	{
		return false;
	}
}
