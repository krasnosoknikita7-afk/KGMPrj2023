using MV.WorldObject;
using MV.WorldObject.MetaData;

public class MVLocalPlayerBuilder : MVLocalPlayerRegistered
{
	public struct EnterPlayStateDataStruct
	{
		public MVTeam selectedTeam;

		public int selectedSpawnRoleCreator;

		public int previousSpawnRoleId;
	}

	private EnterPlayStateDataStruct enterPlayStateData;

	public EnterPlayStateDataStruct EnterPlayStateData
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public int BuildModeSpawnRoleId => 0;

	public MVLocalPlayerBuilder(int actorNumber, int profileID, string regionCode, int planetOwnershipTypeID, UserProfileData userProfileData)
		: base(0, 0, null, 0, null)
	{
	}

	public void SetToDefaultPlayModeSpawnRole()
	{
	}

	public void SetToBuildModeSpawnRole()
	{
	}
}
