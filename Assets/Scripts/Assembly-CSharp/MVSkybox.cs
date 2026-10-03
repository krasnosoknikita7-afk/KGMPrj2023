using System.Collections.Generic;
using UnityEngine;

public class MVSkybox : MVLogicObject, ILogicWorldObject
{
	private bool inventoryObject;

	protected SkyboxManager skybox;

	private const float sunAngle = 80f;

	private const float fogDensity = 0.007f;

	private InteractionFlags defaultInteractionFlags;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public Color SkyboxColor => default;

	public float SunAngle => 0f;

	public float FogDensity => 0f;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public bool SkyboxActive => false;

	public MVSkybox(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void InitializeInventory()
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

	public override void Destroy()
	{
	}

	public void SetDefaultInteractionFlags()
	{
	}

	public void SetDeleteOnlyInteractionFlags()
	{
	}
}
