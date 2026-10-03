using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class CollectTheItemCollectableInstance : MVBlueprintBase, ITriggerBoxEventsHandler, IPickupStateHandler
{
	private CollectTheItemObject collectTheItemObject;

	private CullingSubscriberBase cullingSubscriberBase;

	private UseInteractor useInteractor;

	private bool isTaken;

	private readonly float timeCreated;

	private PickupItemState currentState;

	private bool IsOriginalInstance => false;

	private int OriginalInstanceID => 0;

	public bool HasArrowIndicator => false;

	private int CollectTheItemCollectableID => 0;

	public CollectTheItemCollectableInstance(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Reset()
	{
	}

	public void SetupGreyoutScript(object sender, EditStateEventArgs args)
	{
	}

	private void InitializeInstanceWithData()
	{
	}

	private void SetupCulling()
	{
	}

	private void SetupUseInteractor()
	{
	}

	private void OnEditModeChange(EditModeChangeArgs arg)
	{
	}

	private void SetupInstance()
	{
	}

	private void OnCollected(bool shouldBeActiveOnCollect)
	{
	}

	private void SetBlinker()
	{
	}

	private bool CheckCanUse(int woId, MVInteractableBase interactable)
	{
		return false;
	}

	private bool CanPickupWithoutUse(int instigator)
	{
		return false;
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	private bool SendEnterEvent(int instigator)
	{
		return false;
	}

	private void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	public void OnStateChanged(CullingGroupEvent cullingEvent)
	{
	}

	private bool DoPickup(int instigatorWOID)
	{
		return false;
	}

	public void Enter(int instigatorWoID)
	{
	}

	public void Exit()
	{
	}

	public void SetRotationEnabled(bool enableRotation)
	{
	}

	public override void Destroy()
	{
	}

	public override bool Delete(MVWorldObjectClientManager worldObjectClientManager, ref string errorText)
	{
		return false;
	}

	public void HandleStateChange(PickupItemState state)
	{
	}
}
