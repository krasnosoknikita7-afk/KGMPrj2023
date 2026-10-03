using System.Collections.Generic;

public abstract class MVGamePointRewardLogicObject : MVLogicObject
{
	protected virtual int GamePointRewardAmount => 0;

	public string GamePointString => null;

	public MVGamePointRewardLogicObject(Dictionary<object, object> data, ObjectPrefab prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override void Destroy()
	{
	}

	protected bool HasGamePoints(Dictionary<object, object> dataToCheck)
	{
		return false;
	}

	protected int GetGamePointsRewardAmount(Dictionary<object, object> data)
	{
		return 0;
	}
}
