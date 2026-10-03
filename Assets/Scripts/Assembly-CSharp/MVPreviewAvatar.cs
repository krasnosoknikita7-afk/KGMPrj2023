using System.Collections.Generic;
using UnityEngine;

public class MVPreviewAvatar : MVGroup
{
	private int spawnRoleCreatorId;

	public int SpawnRoleCreatorId
	{
		set
		{
		}
	}

	public MVPreviewAvatar(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public override MVWorldObjectClient Clone(int ownerActorNumber, int cloneGroupId, CloneBookkeeping cloneBookkeeping, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
	{
		return null;
	}

	public override void Select(Color color)
	{
	}

	public override void DeSelect()
	{
	}
}
