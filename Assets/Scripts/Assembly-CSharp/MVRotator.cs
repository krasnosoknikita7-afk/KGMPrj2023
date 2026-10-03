using System.Collections.Generic;
using UnityEngine;

public class MVRotator : MVMovable
{
	protected CullingSubscriberBase cullingSubscriberBase;

	private static HashSet<MVRotator> selectedRotators;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public Vector3 InitAngularVelocity { get; private set; }

	private MVWorldObjectClientManager WOCM => null;

	public bool Horizontal => false;

	public bool Vertical => false;

	public override Vector3 WorldPivot => default;

	public MVRotator(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void SetupCulling()
	{
	}

	private void OnPositionChanged(object sender, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	private void SetupCullingSphere()
	{
	}

	private void Changed(CubeModelChangedEventArgs cubeModelChangedEventArgs)
	{
	}

	private void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	protected override void OnSelectedChanged(bool selected)
	{
	}

	private void MVCubeModelBase_BeingEditedChanged(object sender, EditStateEventArgs e)
	{
	}

	private void WorldObjectClient_SelectedChangedHandler(object sender, SelectedEventArgs e)
	{
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public override void Destroy()
	{
	}

	public override void SetWorldObjectToPurchased()
	{
	}

	public override void AddPreviewBox()
	{
	}
}
