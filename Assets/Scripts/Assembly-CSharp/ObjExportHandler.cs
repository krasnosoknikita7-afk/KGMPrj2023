using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjExportHandler : MonoBehaviour
{
	private static bool picking;

	private const int defaultMask = -262149;

	private static HashSet<int> ignoreIds;

	public static void InitializePicking()
	{
	}

	public static void ExportSelfAvatar()
	{
	}

	private void Update()
	{
	}

	private static bool Pick(ref VoxelHit hit, HashSet<int> ignoreWoIds = null, int layerMask = -262149)
	{
		return false;
	}

	private static bool MVObjectIsType(Transform t, Type type, out int woId)
	{
		woId = default;
		return false;
	}
}
