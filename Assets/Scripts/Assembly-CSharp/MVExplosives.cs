using System.Collections.Generic;
using UnityEngine;

public class MVExplosives : MVLogicObject, ILogicWorldObject
{
	private float damageRadius;

	private float damageValue;

	private float shockwaveAcceleration;

	private GameObject audioGO;

	private AudioLogicCube audioLC;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public MVExplosives(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void InputStateUpdateCallback(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
	{
	}

	public void Explode()
	{
	}
}
