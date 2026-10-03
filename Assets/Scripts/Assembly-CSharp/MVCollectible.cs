using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class MVCollectible : MVGamePointRewardLogicObject
{
	public enum CollectibleClientState
	{
		Visible = 0,
		PickedUp = 1,
		ReShowing = 2,
		Invisible = 3,
		PickingUp = 4
	}

	private CollectibleClientState state;

	private MVCollectibleObject collectibleObject;

	private bool isVisible;

	private float pickedUpStateDuration;

	private float reshowingStateDuration;

	private float pickedUpTime;

	private MVRuntimeDataVariable takenByListRunTimeVariable;

	private List<MVTeam> takenByTeamList;

	private bool initializedInWorld;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public MVCollectible(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	private void Create()
	{
	}

	public override void Initialize()
	{
	}

	public override void Destroy()
	{
	}

	private void SetVisible()
	{
	}

	private void allWorldObjectTriggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	public virtual void OnPickup(int actorNr)
	{
	}

	public override void Reset()
	{
	}

	private void OnWinningConditionFulfilled(IWinningCondition winningCondition)
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

	private void OnTakenByListChange()
	{
	}
}
