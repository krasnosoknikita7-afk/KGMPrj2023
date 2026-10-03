using System.Collections.Generic;

public class MVPulseBox : MVLogicObject, ILogicWorldObject
{
	private const string currentStartTimeKey = "currentStartTime";

	private OutputSignalTransmitter outputSignalTransmitter;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public int CurrentStartTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public MVPulseBox(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void OnSignal(bool isHot, bool wasHot, LogicObjectManager logicObjectManager)
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override void Reset()
	{
	}
}
