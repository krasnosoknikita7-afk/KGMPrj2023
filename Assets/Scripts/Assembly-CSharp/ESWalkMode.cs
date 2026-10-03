internal class ESWalkMode : ESStateBase
{
	private enum EnterPlayFromEditState
	{
		EnterPlayMode = 0,
		SelectTeamOrSpawnRole = 1,
		WaitForRoundToStart = 2
	}

	public override void Enter(EditorStateMachine esm)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	public override void Exit(EditorStateMachine esm)
	{
	}

	private void HandleEnterPlayInEditMode()
	{
	}

	private EnterPlayFromEditState CalculateEnterPlayFromEditState()
	{
		return EnterPlayFromEditState.EnterPlayMode;
	}

	private bool ShouldSelectTeamOrSpawnRole(bool isSpawnRoleValid, bool isTeamValid)
	{
		return false;
	}

	private void HandleEnterState(EnterPlayFromEditState enterState)
	{
	}

	private void HandleEnterPlayMode()
	{
	}

	private void HandleSelectTeamOrSpawnRole()
	{
	}

	private void HanldeWaitForRoundToStart()
	{
	}

	private void TryLockCursor()
	{
	}

	private void SetToHiddenMode()
	{
	}

	private bool WasPlayingAsDefaultAvatar()
	{
		return false;
	}

	private void OnNewSpawnRoleSelected(int newSpawnRoleId)
	{
	}
}
