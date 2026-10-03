using System.Collections.Generic;
using UnityEngine;

public class MVWorldObjectSpawnerVehicle : MVWorldObjectSpawner
{
	private CullingSubscriberBase cullingSubscriberBase;

	private GameObject lodGameObject;

	private GameObject groundAura;

	private bool initFlag;

	private GreyOutObjectScript pickupItemObjectScript;

	private SpawnerObject spawnerObject;

	public int SpawnWorldObjectID => 0;

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public MVWorldObjectSpawnerVehicle(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override void Destroy()
	{
	}

	public override void Initialize()
	{
	}

	protected void SetupCulling()
	{
	}

	private void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	protected virtual void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	public override void InitializeInventory()
	{
	}

	private void InitializeCommon()
	{
	}

	public override void SetupTierInventory()
	{
	}

	protected override void OnSpawnStateChange(SpawnState spawnState)
	{
	}

	public override void Select(Color color)
	{
	}

	protected override bool CheckCanUse(int woId, MVInteractableBase avatarInteractable)
	{
		return false;
	}

	protected override bool Use(int userWoID)
	{
		return false;
	}

	public override bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}

	public override bool OnExitObject(EditorStateMachine e)
	{
		return false;
	}

	public override bool CompareWithKoGaMaPackage(MVWorldObjectClient wo, KoGaMaPackageClient koGaMaPackageClient, ref int insertedByProfileId)
	{
		return false;
	}
}
