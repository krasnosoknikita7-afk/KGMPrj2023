using MV.WorldObject.MetaData;
using UnityEngine.Networking;

public class MVLocalPlayerRegistered : MVLocalPlayer
{
	public MVLocalPlayerRegistered(int actorNumber, int profileID, string regionCode, int planetOwnershipTypeId, UserProfileData userProfileData)
		: base(0, 0, null, 0, null)
	{
	}

	public override void InitializeLeveling(InitialLevelData initialLevelData)
	{
	}

	private void OnXPProgressDataChangeRegistered(XPProgressData xpProgress)
	{
	}

	private void LevelCallback(UnityWebRequest result)
	{
	}

	private void OnLevelChangedLocalReceivedLevelData(int level)
	{
	}

	public override void Destroy()
	{
	}
}
