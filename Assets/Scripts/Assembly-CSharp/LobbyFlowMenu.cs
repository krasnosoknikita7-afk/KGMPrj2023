using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public abstract class LobbyFlowMenu : MonoBehaviour
{
	protected enum LobbyFlowMenuType
	{
		LobbyState = 0,
		Briefing = 1,
		TeamSelect = 2,
		SpawnRoleSelect = 3,
		None = 4
	}

	[SerializeField]
	protected MaskMode cameraMaskMode;

	[SerializeField]
	protected TeamMenu teamMenuPrefab;

	[SerializeField]
	protected WinningConditionBriefing winningConditionBriefingMenuPrefab;

	[SerializeField]
	protected SpawnRoleMenu spawnRoleMenuPrefab;

	private bool haveSetSelectedTeam;

	protected MVTeam selectedTeam;

	private List<LobbyFlowMenuType> menuOrder;

	protected abstract LobbyFlowMenuType MenuType { get; }

	protected MVTeam SelectedTeam
	{
		set
		{
		}
	}

	public virtual void Start()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected void UpdateAvailableMenues()
	{
	}

	protected virtual bool CanShowTeamSelect()
	{
		return false;
	}

	protected virtual bool CanShowBreifing()
	{
		return false;
	}

	protected virtual bool CanShowSpawnRoleSelect()
	{
		return false;
	}

	public void GoToNextMenu()
	{
	}

	public void GoToPreviousMenu()
	{
	}

	protected bool CanGoToNextMenu()
	{
		return false;
	}

	protected LobbyFlowMenuType GetNextMenuType()
	{
		return LobbyFlowMenuType.LobbyState;
	}

	protected LobbyFlowMenuType GetPreviousMenuType()
	{
		return LobbyFlowMenuType.LobbyState;
	}

	protected void GoToMenu(LobbyFlowMenuType newMenuType)
	{
	}

	protected virtual void StartPlaying()
	{
	}
}
