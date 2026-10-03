using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class CollectTheItemCollectable : MVBlueprintBase
{
	private CullingSubscriberBase cullingSubscriberBase;

	private MVCubeModelInstance collectableModel;

	private CollectTheItemCollectableInstance collectableInstance;

	private EditableCubeModelWrapper editableCubeModelWrapper;

	private CollectTheItem controller;

	public Action OnCollectTheItemDestroyed;

	private ObscuredIntVector minBounds;

	private ObscuredIntVector maxBounds;

	private ObscuredInt minCubes;

	public int CollectableModelId => 0;

	public int DropOffId => 0;

	public bool HasArrowIndicator => false;

	public bool HasDropOff => false;

	public CollectTheItemCollectable(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public void InitializeWithController(CollectTheItem controller)
	{
	}

	private void SetupCollectableModel()
	{
	}

	private void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	public Dictionary<string, object> GetItemData()
	{
		return null;
	}

	public void CreateCollectableInstance(Vector3 position, Quaternion rotation)
	{
	}

	public override bool OnExitObject(EditorStateMachine e)
	{
		return false;
	}

	public override bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}

	public void OnStateChanged(CullingGroupEvent cullingEvent)
	{
	}

	public override bool Delete(MVWorldObjectClientManager worldObjectClientManager, ref string errorText)
	{
		return false;
	}

	public override void Destroy()
	{
	}
}
