using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public static class ResolutionManager
{
	public static UnityAction<Vector2> OnReferenceResolution;

	private static CanvasScaler canvasScaler;

	public static Vector2 ReferenceResolution => default;

	public static bool Initialized { get; private set; }

	public static Vector2 PhysicalDistanceToPixels => default;

	public static Vector2 PixelsToPhysicalDistance => default;

	public static float Scale => 0f;

	public static float InverseScale => 0f;

	public static void Init(CanvasScaler canvasScaler)
	{
	}

	public static void Destroy()
	{
	}

	public static void PostDestroyCleanup()
	{
	}
}
