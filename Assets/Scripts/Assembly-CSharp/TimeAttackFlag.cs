using System.Collections.Generic;
using UnityEngine;

public class TimeAttackFlag : MVGamePointRewardLogicObject
{
	private TriggerBoxEvents triggerBoxEvents;

	private bool initializedInWorld;

	private WorldObjectEnableController worldObjectEnableController;

	private UseInteractor useInteractor;

	private float lastCaptureTime;

	private const float captureCooldown = 5f;

	private bool isTimeAttackDebriefingOn;

	private const UseGUIResult purchaseOptions = UseGUIResult.CanAfford | UseGUIResult.CannotAfford;

	private TimeAttackFlagObject timeAttackFlagObject;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 WorldPivot => default;

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public TimeAttackFlag(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void LateInitialize()
	{
	}

	private void InitializeCallbacks()
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

	private bool DoReachTimeAttackFlag(int instigator)
	{
		return false;
	}

	public void OnStartFlagDebriefing(int captureTime)
	{
	}

	public void OnEndFlagDebriefing()
	{
	}

	public override void Destroy()
	{
	}
}
