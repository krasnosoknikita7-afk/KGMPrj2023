using System.Collections.Generic;

public abstract class MVWorldObjectSpawner : MVBlueprintBase
{
	public const string RespawnIntervalDataKey = "RespawnInterval";

	public const string RespawnCountDataKey = "RespawnCount";

	protected MVWorldObjectDocumentationType documentationType;

	protected const string SpawnWorldObjectIDKey = "spawnWorldObjectID";

	protected UseInteractor useInteractor;

	protected SpawnStateWrapper spawnStateWrapper;

	protected int spawnWorldObjectID;

	protected TriggerBoxEvents triggerBoxEvents;

	private int predictTakeTime;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	protected MVWorldObjectSpawner(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	protected MVWorldObjectSpawner(Dictionary<object, object> data, ObjectPrefab prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	private SpawnStateWrapper.SpawnStateConfiguration ReadRespawnStateConfiguration()
	{
		return default;
	}

	private int GetDataByKey(string key, int defaultValue)
	{
		return 0;
	}

	public override void Destroy()
	{
	}

	public void RollbackPrediction()
	{
	}

	public void TakePrediction(int takeTime)
	{
	}

	public void Take(int takeTime)
	{
	}

	public override void OnDataUpdate()
	{
	}

	protected virtual void OnSpawnStateChange(SpawnState spawnState)
	{
	}

	protected abstract bool CheckCanUse(int woId, MVInteractableBase userWoID);

	protected abstract bool Use(int userWoID);
}
