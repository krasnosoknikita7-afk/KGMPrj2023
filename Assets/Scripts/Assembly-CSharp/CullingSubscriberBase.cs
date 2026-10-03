using UnityEngine;
using UnityEngine.Events;

public class CullingSubscriberBase : ICullingSubscriber
{
	private UnityAction<CullingGroupEvent> callback;

	public int DistanceBandIndex { get; set; }

	public int CullingIndex { get; set; }

	public Vector3 Position
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float Radius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public CullingSubscriberBase()
	{
	}

	public CullingSubscriberBase(UnityAction<CullingGroupEvent> callback)
	{
	}

	public CullingSubscriberBase(float radius, Vector3 position, UnityAction<CullingGroupEvent> callback)
	{
	}

	public void Setup(float radius, Vector3 position)
	{
	}

	public void Destroy()
	{
	}

	public virtual void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}
}
