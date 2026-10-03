using System;
using Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.Mediator;
using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using MV.WorldObject.GamePassSystem;
using MV.WorldObject.MetaData;
using MV.WorldObject.SpawnRoles;
using WorldObjectTypes.Avatar.Local;

public abstract class MVLocalPlayer : MVPlayer
{
	public enum PlanetOwnershipType
	{
		None = 0,
		Editor = 1,
		Owner = 2
	}

	protected SpawnRolesMetaData spawnRolesMetaData;

	private PlayerPlanetData playerPlanetData;

	private BoostController boostController;

	private int defaultBodyWoId;

	private const int NrOfTimesDiedOffset = -3729;

	private ObscuredInt numberOfTimesDiedInRound;

	public Action OnInitializeLeveling;

	private readonly SpawnRoleDataMediator spawnRoleDataMediator;

	protected XPProgress xpProgress;

	private int planetOwnershipTypeID;

	public XPProgress.OnXPProgressDataDelegate OnXPProgressData;

	protected int joinTime;

	protected const float respawnDuration = 4f;

	protected float respawnTime;

	protected const float reviveTimeout = 10f;

	private int oldLevel;

	public MVBody Body => null;

	public int DefaultSpawnRoleId => 0;

	public SpawnRoleDataMediator SpawnRoleDataMediator => null;

	public PlayerPlanetData PlayerPlanetData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BoostController BoostController
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public WorldObjectUseRequirementTracker WorldObjectUseRequirementTracker { get; private set; }

	public int DefaultBodyWoId => 0;

	public int PlanetOwnershipTypeID
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public PlanetOwnershipType PlanetOwnership => PlanetOwnershipType.None;

	public XPProgressData XPProgressData => null;

	public int JoinTime => 0;

	public bool CanGetXPProgressData => false;

	public float RespawnDuration => 0f;

	public float RespawnTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float ReviveTimeout => 0f;

	private MVAvatarLocal AvatarLocal => null;

	public bool IsAdmin => false;

	public MVLocalPlayer(int actorNumber, int profileID, string regionCode, int planetOwnershipTypeID, UserProfileData userProfileData)
		: base(0, 0, null, (BuildTarget)0, null, isReady: false, observer: false)
	{
	}

	private void SpawnRoleModeOnOnChange(SpawnRoleModeType value)
	{
	}

	public void SetupPlayerWorldObjects(int defaultBodyWoId, SpawnRolesRuntimeData spawnRolesRuntimeData)
	{
	}

	public virtual void InitializeLeveling(InitialLevelData initialLevelData)
	{
	}

	public void SetSpawnRoleMetaData(SpawnRolesMetaData spawnRolesMetaData)
	{
	}

	public void SetActiveSpawnRole(int existingAvatarWoId)
	{
	}

	public void CreateSpawnRole(int avatarSpawnerWoId)
	{
	}

	public void CreateSpawnRoleFailed()
	{
	}

	private void SuspendCurrentSpawnRole()
	{
	}

	private void UnSuspendCurrentSpawnRole()
	{
	}

	public void AddXp(int currentPlayerXP, XPRewardType typeId, int xpDelta, int memberCount)
	{
	}

	protected void SendXpProgressEvent(XPProgressData xpProgressData)
	{
	}

	protected void OnLevelChangedLocal(int level)
	{
	}

	public virtual void Destroy()
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public void DiedInRound()
	{
	}

	public bool HasDiedInRound()
	{
		return false;
	}

	public void RoundEnded()
	{
	}
}
