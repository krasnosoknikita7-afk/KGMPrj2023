using System.Collections.Generic;
using UnityEngine;

public class ShootableButton : MVLogicObject, IIsLogicObjectFiringEventHandler, ILogicWorldObject
{
	private LogicInteractable interactable;

	private Collider targetCollider;

	private ShootableButtonObject buttonObject;

	private const string durationValueKey = "duration";

	private const string currentTimeValueKey = "cT";

	private const int currentTimeDefaultValue = -1;

	private OutputSignalTransmitter outputSignalTransmitter;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override Vector3 WorldPivot => default;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 OutputConnectorOffset => default;

	private int Duration => 0;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	private int CurrentTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private bool IsActive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ShootableButton(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void InitializeInventory()
	{
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	private void SignalCallback(bool b, bool wasHot, LogicObjectManager logicObjectManager)
	{
	}

	public void OnIsFiringChanged(bool isFiring)
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override void Reset()
	{
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public void Activate(object sender, TakeDamageEventArgs e)
	{
	}

	public void SetToDownState()
	{
	}

	public void SetToUpState()
	{
	}

	public override void Destroy()
	{
	}

	public void OnEditModeChange(EditModeChangeArgs arg)
	{
	}
}
