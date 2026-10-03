using System.Collections.Generic;
using UnityEngine;

public class UseLever : MVLogicObject, IIsLogicObjectFiringEventHandler, ILogicWorldObject
{
	private UseLeverObject useLeverObject;

	private float minY;

	private float speed;

	private const string beginActivateValueKey = "beginActivated";

	private const string isActivateValueKey = "a";

	private bool requestSend;

	private bool localIsDown;

	private OutputSignalTransmitter outputSignalTransmitter;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 WorldPivot => default;

	public override Vector3 OutputConnectorOffset => default;

	private bool BeginActivated => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	private bool IsActivated
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public UseLever(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void SignalCallback(bool b, bool wasHot, LogicObjectManager logicObjectManager)
	{
	}

	protected override void OnUpdate()
	{
	}

	public bool Use(int userWoID)
	{
		return false;
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

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public override void Reset()
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override void Destroy()
	{
	}

	public void OnEditModeChange(EditModeChangeArgs arg)
	{
	}

	public void OnIsFiringChanged(bool isFiring)
	{
	}
}
