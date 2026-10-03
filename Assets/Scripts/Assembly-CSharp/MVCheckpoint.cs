using System.Collections.Generic;
using UnityEngine;

public class MVCheckpoint : MVLogicObject
{
	private MVCheckpointObject checkpointObject;

	private UseInteractor useInteractor;

	private const UseGUIResult purchaseOptions = UseGUIResult.CanAfford | UseGUIResult.CannotAfford;

	private bool playingAnimation;

	protected override bool HasVisualsInPlaymode => false;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override Vector3 WorldPivot => default;

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public MVCheckpoint(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	protected override void OnUpdate()
	{
	}

	public override void Initialize()
	{
	}

	private void SetupUseInteractor()
	{
	}

	public override void OnDataUpdate()
	{
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	public override void Destroy()
	{
	}

	private bool DoReachCheckpoint(int instigatorId)
	{
		return false;
	}

	private void DoHeal(int instigator)
	{
	}
}
