using System.Collections.Generic;
using UnityEngine;

public class MVFlag : MVGamePointRewardLogicObject
{
	private TriggerBoxEvents triggerBoxEvents;

	private bool initializedInWorld;

	private WorldObjectEnableController worldObjectEnableController;

	private UseInteractor useInteractor;

	private const UseGUIResult purchaseOptions = UseGUIResult.CanAfford | UseGUIResult.CannotAfford;

	private FlagObject flagObject;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 WorldPivot => default;

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public MVFlag(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
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

	private bool DoCaptureFlag(int instigator)
	{
		return false;
	}

	public override void Destroy()
	{
	}
}
