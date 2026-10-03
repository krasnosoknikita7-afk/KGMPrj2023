using System.Collections.Generic;
using UnityEngine;

public class MVMovingPlatformGroup : MVBlueprintBase
{
	private LineRenderer lineRenderer;

	private Dictionary<object, object> nodeMap;

	private Dictionary<object, object> nextNodeMap;

	private MVMovingPlatformNode startNode;

	private Dictionary<int, MVMovingPlatformNode> nodeIdToWoMap;

	private Dictionary<int, int> woIdToNodeIdMap;

	private MVMovingPlatform platform;

	private bool initializeFailed;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public MVMovingPlatform Platform => null;

	public override bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MVMovingPlatformGroup(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void InitializeInventory()
	{
	}

	private void InitializeCommon()
	{
	}

	private void UpdateLine()
	{
	}

	private void WorldObjectClient_ScaleChangedHandler(object sender, ScaleChangedEventArgs e)
	{
	}

	private void WorldObjectClient_PositionChangedHandler(object sender, PositionChangedEventArgs e)
	{
	}

	private void WorldObjectClient_RotationChangedHandler(object sender, RotationChangedEventArgs e)
	{
	}

	private void WorldObjectClient_SelectedChangedHandler(object sender, SelectedEventArgs e)
	{
	}

	public override bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}

	public override void SetWorldObjectToPurchased()
	{
	}

	public override void AddPreviewBox()
	{
	}

	private void AddPreviewBoxesToChildren()
	{
	}
}
