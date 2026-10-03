using System;
using MV.WorldObject;

public static class LogicClientsideFactory
{
	public static IInputSignalReceiver CreateInputSignalReceiverAnd(MVWorldObject worldObject, bool defaultSignal, Action<bool, bool, LogicObjectManager> signalCallback)
	{
		return null;
	}

	public static IInputSignalReceiver CreateInputSignalReceiver(MVWorldObject worldObject, bool defaultInput, Action<bool, bool, LogicObjectManager> signalCallback)
	{
		return null;
	}

	public static IInputSignalReceiver CreateStateChangeInputSignalReceiver(MVWorldObject worldObject, bool defaultInput, Action<bool, bool, LogicObjectManager> signalCallback, Action<LogicInputState, LogicObjectManager> inputStateUpdateCallback)
	{
		return null;
	}
}
