using System.Collections.Generic;
using MV.Common;
using UnityEngine.Events;

public static class AccessoryDataManager
{
	public static UnityAction readyCallback;

	private static bool accessoriesRequested;

	private static bool accessoriesReady;

	private static AccessoryShopDataClient accessoryShopData;

	public static int AccessoryBundleId => 0;

	public static AccessoryBundleClient AccessoryBundleClient => null;

	public static void SetReady()
	{
	}

	public static void Reset()
	{
	}

	public static void SetAccessoryData(string accessoryData)
	{
	}

	public static void SetToOwns(int streamingAssetId)
	{
	}

	public static AccessoryDataClient GetAccessoryDataByStreamingAssetId(int id)
	{
		return null;
	}

	public static AccessoryDataClient GetAccessoryDataByMetaDataId(int id)
	{
		return null;
	}

	public static Dictionary<AccessoryCategory, List<AccessoryDataClient>> GetAccessoriesCategoryMap()
	{
		return null;
	}

	public static List<AccessoryDataClient> GetAccessoriesByCategoryId(AccessoryCategory category)
	{
		return null;
	}
}
