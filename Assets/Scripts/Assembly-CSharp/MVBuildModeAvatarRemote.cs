using System.Collections.Generic;
using UnityEngine;

public class MVBuildModeAvatarRemote : MVBuildModeAvatar, ISpawnRoleRemote
{
	private LaserPointer laserPointer;

	private AvatarRemoteBuildMode avatarRemoteBuildMode;

	private DynamicCullingHandler cullingHandler;

	int ISpawnRoleRemote.Id => 0;

	public MVBuildModeAvatarRemote(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Destroy()
	{
	}

	public void Activate(int idFrom, Vector3 position, Quaternion rotation)
	{
	}

	public void DeActivate(int idTo)
	{
	}

	private void SetLaserPointerVisibility(bool isVisible)
	{
	}

	protected override Vector3 GetLookDirection()
	{
		return default;
	}
}
