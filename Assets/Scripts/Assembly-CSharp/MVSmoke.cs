using System.Collections.Generic;
using UnityEngine;

public class MVSmoke : MVLogicObject, ILogicWorldObject
{
	private ParticleSystem particleSystem;

	private float lengthCullingScale;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public MVSmoke(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	protected CullingSubscriberBase SetupSmokeCulling(float radius, GameObject lodGameObject)
	{
		return null;
	}

	private void OnInputStateUpdate(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
	{
	}

	public override void InitializeInventory()
	{
	}

	private void ToggleEmitter(bool toggle)
	{
	}

	public override void OnDataUpdate()
	{
	}

	private void SetSmokeProperties()
	{
	}
}
