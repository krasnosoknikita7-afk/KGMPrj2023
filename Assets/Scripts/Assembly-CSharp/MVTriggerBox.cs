using System.Collections.Generic;
using UnityEngine;

public class MVTriggerBox : MVLogicObject, ITriggerBoxEventsHandler
{
	private TriggerBoxEvents triggerBoxEvents;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 OutputConnectorOffset => default;

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public MVTriggerBox(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	private void triggerBoxEvents_TriggerExit(object sender, TriggerEventArgs e)
	{
	}

	public void OnEnter(MVPlayer player)
	{
	}

	public void OnExit(MVPlayer player)
	{
	}

	public void Enter(int instigatorId)
	{
	}

	public void Exit()
	{
	}

	public override void Destroy()
	{
	}
}
