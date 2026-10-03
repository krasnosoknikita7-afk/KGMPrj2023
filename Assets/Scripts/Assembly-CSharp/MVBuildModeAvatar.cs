using System.Collections.Generic;
using UnityEngine;

public abstract class MVBuildModeAvatar : MVGroup, IUpdatecontrollerSubscriberLateUpdate, IUpdatecontrollerSubscriberBase
{
	protected MVBody body;

	protected AvatarLimbManager limbManager;

	protected MVRuntimeDataVariable CurrentItem;

	protected LimbRotationRuntimeData limbRotationRuntimeData;

	public AvatarLimbManager LimbManager => null;

	public MVBuildModeAvatar(Dictionary<object, object> data, GameObject prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Destroy()
	{
	}

	public override void AddChild(MVWorldObjectClient child)
	{
	}

	public void UpdateControllerLateUpdate()
	{
	}

	protected LaserPointer InitLaser(bool isLocal)
	{
		return null;
	}

	protected abstract Vector3 GetLookDirection();
}
