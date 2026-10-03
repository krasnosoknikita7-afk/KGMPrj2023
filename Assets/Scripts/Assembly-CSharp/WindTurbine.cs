using System.Collections.Generic;
using UnityEngine;

public class WindTurbine : MVLogicObject, ILogicWorldObject, IUpdatecontrollerSubscriberFixedUpdate, IUpdatecontrollerSubscriberBase
{
	private readonly Dictionary<int, MVRigidBody> affectedBodies;

	private bool isActive;

	private float windStrength;

	private float windAreaSize;

	private float windPitch;

	private readonly List<int> keysToRemove;

	private const float MaxWindStrength = 280f;

	private const float MaxWindAreaSize = 20f;

	private readonly WindTurbineObject windTurbineObject;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override Vector3 WorldPivot => default;

	public override Vector3 InputConnectorOffset => default;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public WindTurbine(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
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

	private void SetData()
	{
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public override void UpdateControllerFixedUpdate()
	{
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	private void triggerBoxEvents_TriggerExit(object sender, TriggerEventArgs e)
	{
	}

	private void EnterWindZone(int instigatorWOID)
	{
	}

	private void ExitWindZone(int instigatorWOID)
	{
	}

	private void Rescale()
	{
	}

	private void Rotate()
	{
	}

	private void ToggleTurbine(bool state)
	{
	}

	public override void InitializeInventory()
	{
	}

	public override void Destroy()
	{
	}

	public void OnEditModeChange(EditModeChangeArgs arg)
	{
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}
}
