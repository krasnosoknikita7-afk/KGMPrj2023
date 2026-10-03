using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class CollectTheItemDropOff : MVBlueprintBase, ILogicWorldObject
{
	private EditableCubeModelWrapper editableCubeModelWrapper;

	private CollectTheItemDropOffObject triggerObject;

	private CullingSubscriberBase cullingSubscriberBase;

	private CollectTheItem controller;

	private const string isActiveKey = "isActive";

	private const string doOnce = "doOnce";

	private ObscuredIntVector minBounds;

	private ObscuredIntVector maxBounds;

	private ObscuredInt minCubes;

	private OutputSignalTransmitter outputSignalTransmitter;

	public Action<bool> OnPickupCollected;

	private bool sendSignal;

	public override bool HasOutputConnector => false;

	public override bool HasInputConnector => false;

	public override Vector3 OutputConnectorOffset => default;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public bool IsActive => false;

	public bool DoOnce => false;

	public CollectTheItemDropOff(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public void InitializeWithController(CollectTheItem controller)
	{
	}

	public override void Initialize()
	{
	}

	private void SignalCallback(bool b, bool wasHot, LogicObjectManager logicObjectManager)
	{
	}

	private void OnChunkEditReset(object sender, EditStateEventArgs args)
	{
	}

	public void ReInitializeVisuals()
	{
	}

	private void OnEditModeChange(EditModeChangeArgs arg)
	{
	}

	private void OnCollected(bool shouldbeActiveOnCollect)
	{
	}

	public override void Reset()
	{
	}

	private void SetupCulling()
	{
	}

	private void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	public void OnStateChanged(CullingGroupEvent cullingEvent)
	{
	}

	public override void OnDataUpdate()
	{
	}

	public void DropWoId(int instigatorWoID)
	{
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	public override void Destroy()
	{
	}

	public override bool OnExitObject(EditorStateMachine e)
	{
		return false;
	}

	public override bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}

	public override bool Delete(MVWorldObjectClientManager worldObjectClientManager, ref string errorText)
	{
		return false;
	}
}
