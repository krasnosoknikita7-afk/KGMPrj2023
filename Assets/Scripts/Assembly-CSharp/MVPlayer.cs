using System;
using MV.Common;
using MV.WorldObject;
using MV.WorldObject.GamePassSystem;
using MV.WorldObject.MetaData;
using MV.WorldObject.SpawnRoles;
using MV.WorldObject.Subscription;
using UnityEngine.Events;

public class MVPlayer
{
	private int checkpointWOID;

	protected PlayerPlanetDataRemote playerPlanetDataRemote;

	protected int level;

	public Action OnGoldAmountChange;

	public UnityAction<int> OnLevelChanged;

	public UnityAction OnCheckpointReached;

	public UnityAction OnPause;

	public UnityAction OnResume;

	public UnityAction OnObserve;

	private PlayerGameState playerState;

	protected SpawnRolesManager spawnRolesManager;

	public int ProfileID { get; private set; }

	public bool IsTourist => false;

	public int WoId => 0;

	public int ActorNr { get; private set; }

	public string RegionCode { get; private set; }

	public BuildTarget BuildTarget { get; private set; }

	public PlayerPlanetDataRemote PlayerPlanetDataRemote
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UserProfileData UserProfileData { get; private set; }

	public SubscriptionRulesWrapper SubscriptionRules { get; private set; }

	public bool IsSubscriber => false;

	public PlayerGameState PlayerState
	{
		get
		{
			return PlayerGameState.None;
		}
		set
		{
		}
	}

	public bool IsReady => false;

	public bool IsPlayerStateInWorld => false;

	public int Level
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public MVTeam Team { get; set; }

	public SpawnRolesManager SpawnRolesManager => null;

	public MVPlayer(int actorNumber, int profileID, string regionCode, BuildTarget buildTarget, UserProfileData userProfileData, bool isReady, bool observer)
	{
	}

	public MVPlayer(int actorNumber, int profileID, int level, string regionCode, BuildTarget buildTarget, UserProfileData userProfileData, bool isReady, bool observer, PlayerPlanetDataRemote playerPlanetDataRemote)
	{
	}

	public void NotifyAvatarCreated(int id)
	{
	}

	public bool IsOnSameTeam(MVPlayer other)
	{
		return false;
	}

	public bool IsOnTeam(MVTeam otherTeam)
	{
		return false;
	}

	public bool IsOnSameTeam(MVWorldObjectClient wo)
	{
		return false;
	}

	public void SetCheckpoint(int woid)
	{
	}

	public MVCheckpoint GetCheckpoint()
	{
		return null;
	}

	public void ResetCheckpoint()
	{
	}

	public int GetGameStat(GameStatCounterType gameStatCounterType)
	{
		return 0;
	}

	public void SetReady()
	{
	}

	public void SetupSpawnRoleManager(ISpawnRoleChangeHandler spawnRoleChangeHandler, SpawnRolesRuntimeData spawnRolesRuntimeData)
	{
	}
}
