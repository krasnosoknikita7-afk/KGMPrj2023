using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class MVGameCoinChest : MVLogicObject
{
	private enum GameCoinChestClientState
	{
		Closed = 0,
		Opening = 1,
		Open = 2
	}

	private const UseGUIResult purchaseOptions = UseGUIResult.CanAfford | UseGUIResult.CannotAfford;

	private GameCoinChestClientState state;

	private int instigator;

	private UseInteractor useInteractor;

	private MVGameCoinChestObject chestObject;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MVGameCoinChest(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void SetupUseInteractor()
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override void InitializeInventory()
	{
	}

	protected override void OnUpdate()
	{
	}

	public bool IsUsable(int woId, MVInteractableBase avatarInteractable)
	{
		return false;
	}

	private bool OpenChest(int instigatorID)
	{
		return false;
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	public override void Reset()
	{
	}

	private void DoOpen()
	{
	}

	public override MVWorldObjectClient Clone(int ownerActorNumber, int cloneGroupId, CloneBookkeeping cloneBookkeeping, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
	{
		return null;
	}

	public override MVWorldObject DeepCopy()
	{
		return null;
	}

	public override void Destroy()
	{
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}
}
