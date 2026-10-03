using System.Collections.Generic;
using UnityEngine;

public class TriggerCube : MVLogicObject, IIsLogicObjectFiringEventHandler, ILogicWorldObject
{
	private Vector3 outputConnectorOffset;

	private TriggerCubePrefab objPrefab;

	private bool isDown;

	private OutputSignalTransmitter outputSignalTransmitter;

	private UseInteractor useInteractor;

	private const UseGUIResult purchaseOptions = UseGUIResult.CanAfford | UseGUIResult.CannotAfford;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 OutputConnectorOffset => default;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public TriggerCube(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void InitializeInventory()
	{
	}

	public override void OnDataUpdate()
	{
	}

	private void SetScale()
	{
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	private bool DoEnter(int instigator)
	{
		return false;
	}

	private void triggerBoxEvents_TriggerExit(object sender, TriggerEventArgs e)
	{
	}

	private void Callback(bool b, bool wasHot, LogicObjectManager logicObjectManager)
	{
	}

	public void OnIsFiringChanged(bool isFiring)
	{
	}
}
