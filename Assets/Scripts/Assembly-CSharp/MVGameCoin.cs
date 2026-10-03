using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class MVGameCoin : MVLogicObject
{
	public enum GameCoinClientState
	{
		Visible = 0,
		PickedUp = 1,
		ReShowing = 2,
		Invisible = 3
	}

	private MVGameCoinObject pickupObject;

	private UseInteractor useInteractor;

	private GameCoinClientState state;

	private bool isVisible;

	private float pickedUpStateDuration;

	private float reshowingStateDuration;

	private float pickedUpTime;

	private const UseGUIResult purchaseOptions = UseGUIResult.CanAfford | UseGUIResult.CannotAfford;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public MVGameCoin(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void SetupUserInteractor()
	{
	}

	public override void OnDataUpdate()
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

	private void SetVisible()
	{
	}

	public virtual bool OnPickup(int instigatorID)
	{
		return false;
	}

	public bool IsCoinTakeable(int woId, MVInteractableBase avatarInteractable)
	{
		return false;
	}

	public override void Reset()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	private void OnWinningConditionFulfilled(IWinningCondition winningCondition)
	{
	}
}
