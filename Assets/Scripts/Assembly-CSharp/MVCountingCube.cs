using System.Collections.Generic;
using UnityEngine;

public class MVCountingCube : MVLogicObject, ILogicWorldObject
{
	private const float ConnectorOffset = 1.5f;

	private Vector3 ObjectSize;

	private MVCountingCubeObject cubeObject;

	private const string currentValueKey = "currentValue";

	private const string startingValueKey = "startingValue";

	private const string resetValueKey = "reset";

	private OutputSignalTransmitter outputSignalTransmitter;

	private bool isHot;

	private int prevVal;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 OutputConnectorOffset => default;

	public override Vector3 InputConnectorOffset => default;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public int CurrentValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int StartingValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool ResetDataValue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MVCountingCube(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
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

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public override void Reset()
	{
	}

	private void SetText()
	{
	}

	private void PlaySound()
	{
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}
}
