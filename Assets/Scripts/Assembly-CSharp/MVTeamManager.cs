using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MV.WorldObject;

public class MVTeamManager
{
	public delegate void OnTeamsUpdatedDelegate();

	private readonly Dictionary<MVTeam, string> teamNamesDefault;

	private Dictionary<MVTeam, string> teamNames;

	public OnTeamsUpdatedDelegate OnTeamsUpdated;

	[CompilerGenerated]
	private EventHandler<TeamEventArgs> m_OnTeamAdded;

	[CompilerGenerated]
	private EventHandler<TeamEventArgs> m_OnTeamRemoved;

	private Dictionary<MVTeam, HashSet<int>> teams;

	public int NumSpawnPoint => 0;

	public event EventHandler<TeamEventArgs> OnTeamAdded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<TeamEventArgs> OnTeamRemoved
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public List<TeamData> GetTeamDatas(GameStatCounterType gameStatCounterType)
	{
		return null;
	}

	public Dictionary<MVTeam, string> GetTeamNames()
	{
		return null;
	}

	public void UpdateTeamName(MVTeam team, string name)
	{
	}

	public void SetTeamNameToDefault(MVTeam team)
	{
	}

	public void OnAddSpawnPoint(int woId, MVTeam team)
	{
	}

	public void OnRemoveSpawnPoint(int id, MVTeam team)
	{
	}

	public List<MVWorldObjectClient> GetSpawnPointsForTeam(MVTeam team)
	{
		return null;
	}

	public List<MVWorldObjectClient> GetOnlySpawnPointsForTeam(MVTeam team)
	{
		return null;
	}

	public MVTeam GetDefaultTeam()
	{
		return MVTeam.Blue;
	}

	public bool IsTeamActive(MVTeam team)
	{
		return false;
	}

	public int GetScore(MVTeam team, GameStatCounterType gameStatCounterType)
	{
		return 0;
	}

	public int TeamCount()
	{
		return 0;
	}

	public List<MVTeam> GetTeamList()
	{
		return null;
	}

	public bool HasTeam(MVTeam team)
	{
		return false;
	}

	public bool TeamHasSpawnPoints(MVTeam team)
	{
		return false;
	}

	public bool TeamHasSpawnRoles(MVTeam team)
	{
		return false;
	}

	public List<MVPlayer> GetPlayersInTeam(MVTeam team)
	{
		return null;
	}

	public MVTeam GetTeamFromActorNr(int actorNumber)
	{
		return MVTeam.Blue;
	}

	public int GetNoOfPlayersInTeam(MVTeam team)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
