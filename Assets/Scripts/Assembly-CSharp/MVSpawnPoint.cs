using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public abstract class MVSpawnPoint : MVLogicObject
{
	public const string spawnPointDataOnlyFirstSpawn = "onlyFirstSpawn";

	private bool isInWorld;

	private bool? spawnPointOnlyFirstDeath;

	protected override bool HasVisualsInPlaymode => false;

	public bool SpawnPointOnlyFirstDeath => false;

	public MVSpawnPoint(Dictionary<object, object> data, ObjectPrefab prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Destroy()
	{
	}

	private static MVTeam WOTypeToTeamIndex(WorldObjectType type)
	{
		return MVTeam.Blue;
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public override bool Delete(MVWorldObjectClientManager worldObjectClientManager, ref string errorText)
	{
		return false;
	}
}
