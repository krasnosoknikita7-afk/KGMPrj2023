using System.Collections.Generic;
using UnityEngine;

public class MVPressurePlate : MVLogicObject, IIsLogicObjectFiringEventHandler, ILogicWorldObject
{
	private MVPressurePlateObject plateObject;

	private bool isDown;

	private bool localIsDown;

	private float minY;

	private float speed;

	private const UseGUIResult purchaseOptions = UseGUIResult.CanAfford | UseGUIResult.CannotAfford;

	private UseInteractor useInteractor;

	private OutputSignalTransmitter outputSignalTransmitter;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 OutputConnectorOffset => default;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public override Vector3 WorldPivot => default;

	public MVPressurePlate(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public void OnIsFiringChanged(bool isFiring)
	{
	}

	private void Callback(bool b, bool wasHot, LogicObjectManager logicObjectManager)
	{
	}

	public override void OnDataUpdate()
	{
	}

	protected override void OnUpdate()
	{
	}

	public override void InitializeInventory()
	{
	}

	public override void SetupTierInventory()
	{
	}

	public override void UnSetupTierInventory()
	{
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	private void triggerBoxEvents_TriggerExit(object sender, TriggerEventArgs e)
	{
	}

	private bool DoEnter(int instigatorWOID)
	{
		return false;
	}

	private void DoExit(int instigatorWOID)
	{
	}

	public override void Destroy()
	{
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	private bool IsVisible()
	{
		return false;
	}

	private void SetVisibility()
	{
	}
}
