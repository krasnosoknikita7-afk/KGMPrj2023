using System.Collections.Generic;

public class MVToggleBox : MVLogicObject, ILogicWorldObject
{
	private const string toggledValueKey = "toggled";

	private const string onceValueKey = "once";

	private OutputSignalTransmitter outputSignalTransmitter;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public bool Toggled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Once
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MVToggleBox(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void InputStateUpdateCallback(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
	{
	}

	public override void Reset()
	{
	}

	public override void OnDataUpdate()
	{
	}
}
