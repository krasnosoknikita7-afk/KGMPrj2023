using MV.WorldObject;
using UnityEngine;

public static class DrawPlane
{
	private static DrawPlaneControllerUUI drawPlaneController;

	public static bool IsDrawPlaneActive => false;

	public static int Altitude => 0;

	public static DrawPlaneAxis Orientation
	{
		get
		{
			return DrawPlaneAxis.X;
		}
		set
		{
		}
	}

	public static Vector3 Pos => default;

	public static bool InputEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static void Initialize(DrawPlaneControllerUUI drawPlaneController)
	{
	}

	public static void Reset()
	{
	}

	public static bool Pick(ref Vector3 hit)
	{
		return false;
	}

	public static void DrawPlaneToModel(GameObject gameObject)
	{
	}

	public static void ToggleDrawPlane()
	{
	}

	public static void HideDrawPlane()
	{
	}

	public static void ReturnDrawPlaneToLandscape()
	{
	}

	public static bool GetCubePosOnDrawplane(GameObject gameObject, out IntVector intVectorHitPosition)
	{
		intVectorHitPosition = default;
		return false;
	}

	public static void MoveDrawPlane(int dir)
	{
	}
}
