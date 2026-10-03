using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using MV.WorldObject;

public class MVRandomBox : MVLogicObject, ILogicWorldObject
{
	private const string currentRandomValuesKey = "currentRandomValues";

	private const string currentValueKey = "currentValue";

	private const int currentValueDefault = 0;

	private RandomGenerator randomGenerator;

	private OutputSignalTransmitterSpecific _outputSignalTransmitter;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	private int CurrentValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private ObscuredInt[] CurrentRandomValues => null;

	public MVRandomBox(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public void SetRandomIndex(int randomIndex)
	{
	}

	private void InputStateUpdateCallback(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
	{
	}

	public override void Reset()
	{
	}
}
