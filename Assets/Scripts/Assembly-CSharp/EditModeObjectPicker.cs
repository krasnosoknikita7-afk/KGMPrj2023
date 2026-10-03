using System.Collections.Generic;
using UnityEngine;

public static class EditModeObjectPicker
{
	private const int defaultMask = -262149;

	private static Camera mainCamera;

	private static Camera MainCamera => null;

	public static bool Pick(ref VoxelHit hit, HashSet<int> ignoreWoIds = null, int layerMask = -262149)
	{
		return false;
	}

	public static bool GetPickingInfo(MVCubeModelBase cr, ref CubePickingInfo info)
	{
		return false;
	}

	private static bool IsHitPickup(VoxelHit hit)
	{
		return false;
	}
}
