using System.Collections.Generic;
using UnityEngine;

public abstract class MVLogicObject : MVWorldObjectClient, IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
{
	private Bounds localBounds;

	protected CullingSubscriberBase cullingSubscriberBase;

	private GameObject lodGameObject;

	protected abstract bool HasVisualsInPlaymode { get; }

	protected virtual void OnUpdate()
	{
	}

	public override void Reset()
	{
	}

	protected MVLogicObject(Dictionary<object, object> data, ObjectPrefab prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public override void Initialize()
	{
	}

	public void SetLocalBounds()
	{
	}

	protected CullingSubscriberBase SetupCulling(GameObject lodGameObject, float cullingRadius = 2f)
	{
		return null;
	}

	private void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	protected virtual void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	public override void Destroy()
	{
	}

	public virtual void UpdateControllerUpdate()
	{
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public override void Select(Color color)
	{
	}

	public override void DeSelect()
	{
	}

	public override void InitializeInventory()
	{
	}

	public override void SetupTierInventory()
	{
	}

	private void StopCulling()
	{
	}

	protected Bounds ComputeLocalBounds(Vector3 origin, Renderer[] meshRenderers)
	{
		return default;
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public virtual void UpdateControllerFixedUpdate()
	{
	}
}
