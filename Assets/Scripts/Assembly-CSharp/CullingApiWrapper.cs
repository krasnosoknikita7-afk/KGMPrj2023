using System.Collections.Generic;
using UnityEngine;

public static class CullingApiWrapper
{
	public const int dynamicObjectsDistanceBand = 3;

	public const int overrideDynamicObjectsDistanceBand = 2;

	public const int npcDistanceBandOverride = 3;

	public static float baseDistance;

	public static BoundingSphere[] spheres;

	private const int extraSpheres = 1000;

	private static CullingGroup cullingGroup;

	private static Dictionary<int, ICullingSubscriber> cullingSubscribers;

	private static readonly float[] sizes;

	public static int NumBoundSpheres { get; private set; }

	public static Camera TargetCamera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void Init(int initialSphereCount, Camera camera, float newBaseDistance)
	{
	}

	public static bool IsVisible(int index)
	{
		return false;
	}

	public static int GetDistance(int index)
	{
		return 0;
	}

	public static void SetDistanceReferencePoint(Transform distanceReferencePoint)
	{
	}

	public static void Subscribe(ICullingSubscriber iCullingGroupSubscriber)
	{
	}

	public static void UnSubscribe(ICullingSubscriber unSubscriber)
	{
	}

	public static void DebugVisualize()
	{
	}

	public static bool Visible(CullingGroupEvent cullingGroupEvent, int distanceBandIndex)
	{
		return false;
	}

	public static void ChangeDistances(float newBaseDistance, Camera camera)
	{
	}

	public static int GetDistanceBand(float radius)
	{
		return 0;
	}

	private static float[] UpdateDistances(float newBaseDistance)
	{
		return null;
	}

	public static void Destroy()
	{
	}

	public static void PostDestroyCleanup()
	{
	}

	public static void DebugCullingEvent(CullingGroupEvent cullingGroupEvent)
	{
	}

	private static void AddBoundingSphere()
	{
	}

	private static void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}
}
