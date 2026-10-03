using System.Collections.Generic;
using MV.WorldObject.GamePassSystem.GamePassProgressionDataObject;
using UnityEngine;

public class MVGamePassProgressionDataObject : MVWorldObjectClient
{
	public const string gamePassProgressionDataObjectKey = "gamePassProgressionDataObject";

	public const string gamePassProgressionDataObjectValidationKey = "gamePassProgressionDataObjectValidation";

	public const string gamePassProgressionEnabledKey = "gamePassProgressionEnabled";

	public GamePassProgressionDataObjectShared GamePassProgressionDataObjectShared
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GamePassProgressionDataObjectSharedValidator GamePassProgressionDataObjectSharedValidator => null;

	public bool EnableProgression => false;

	public MVGamePassProgressionDataObject(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public override void OnDataUpdate()
	{
	}
}
