using System.Collections.Generic;

public class MVTimeTrigger : MVLogicObject, ILogicWorldObject
{
	private const string timeValueKey = "time";

	private const string durationValueKey = "duration";

	private const string currentTimeValueKey = "cT";

	private const int currentTimeDefaultValue = -1;

	private OutputSignalTransmitter outputSignalTransmitter;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public int DelayTime => 0;

	public int ActiveDurationTime => 0;

	public int CurrentTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public MVTimeTrigger(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void InputStateUpdateCallback(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override void Reset()
	{
	}
}
