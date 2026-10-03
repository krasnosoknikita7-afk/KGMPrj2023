using UnityEngine;

public class CullingSubscriberDynamic : IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase, ICullingSubscriber
{
	private int cullingBandIndex;

	private int overrideDistanceBandIndex;

	private GameObject root;

	private Transform rootTransform;

	private GameObject[] children;

	public int CullingIndex { get; set; }

	public CullingSubscriberDynamic(float radius, int cullingBandIndex, GameObject root, GameObject[] children = null)
	{
	}

	public void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void SetCullingRadius(float radius)
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	public void Destroy()
	{
	}
}
