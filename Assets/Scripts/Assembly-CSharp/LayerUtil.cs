using UnityEngine;

public static class LayerUtil
{
	public static string GetName(LayerFlags layers)
	{
		return null;
	}

	public static int GetLayerNumber(LayerFlags layer)
	{
		return 0;
	}

	public static LayerMask GetMask(LayerFlags layerFlags)
	{
		return default;
	}

	public static bool HasFlags(LayerFlags layersMask, int layerFlags)
	{
		return false;
	}

	public static bool HasFlags(int layersMask, LayerFlags layerFlags)
	{
		return false;
	}

	public static bool HasFlags(LayerFlags layersMask, LayerFlags layerFlags)
	{
		return false;
	}

	public static bool HasFlags(int layersMask, int layerFlags)
	{
		return false;
	}

	public static void SetLayerRecursively(this Transform transfrom, int layer)
	{
	}

	public static void SetLayerRecursively(Transform transfrom, string layer)
	{
	}

	public static void SetLayerRecursively(Transform transfrom, LayerMask layersToChange, int layer)
	{
	}

	public static void SetLayerRecursively(Transform transfrom, string layerToChange, string layer)
	{
	}

	public static void SetLayerRecursively(this GameObject gameObject, int layer)
	{
	}
}
