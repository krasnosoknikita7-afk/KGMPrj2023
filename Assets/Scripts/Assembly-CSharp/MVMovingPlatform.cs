using System.Collections.Generic;
using UnityEngine;

public class MVMovingPlatform : MVMovable
{
	private MVMovingPlatformNode start;

	private MVMovingPlatformNode end;

	public MVMovingPlatformNode Start => null;

	public MVMovingPlatformNode End => null;

	protected override Vector3 WorldVelocity => default;

	public MVMovingPlatform(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	public void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	public void MoveBetweenNodes(MVMovingPlatformNode start, MVMovingPlatformNode end)
	{
	}

	public void RecalculateMovement()
	{
	}

	private void MVCubeModelBase_BeingEditedChanged(object sender, EditStateEventArgs e)
	{
	}

	protected override void OnSelectedChanged(bool selected)
	{
	}
}
