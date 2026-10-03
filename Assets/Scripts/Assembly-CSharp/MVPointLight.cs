using System.Collections.Generic;
using UnityEngine;

public class MVPointLight : MVLogicObject, ILogicWorldObject
{
	private MVPointLightObject lightObject;

	private Light lightComponent;

	private float minumumScale;

	private float rangeMaxValue;

	private float scaleRestriction;

	private bool inputVisible;

	protected override bool HasVisualsInPlaymode => false;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public MVPointLight(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	protected void SetupLightCulling(float radius)
	{
	}

	private void OnInputStateUpdate(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
	{
	}

	public override void OnDataUpdate()
	{
	}

	private bool IsVisible()
	{
		return false;
	}

	private void UpdateVisible()
	{
	}

	private void UpdateTexture()
	{
	}

	private void UpdateColorForLightSphere()
	{
	}

	private void SetLightToData()
	{
	}
}
