using System;
using MV.Common;
using MV.WorldObject.AntiCheat;

public static class GamePassProgressionController
{
	private static MVGamePassProgressionDataObject progressionDataObject;

	private static bool isInitialized;

	public static Action OnGamePassesProgressionUpdate;

	public static bool IsProgressionEnabled => false;

	public static void Initialize()
	{
	}

	public static int GetXPReward(GamePassTier tier)
	{
		return 0;
	}

	public static void SetXPReward(GamePassTier tier, int xpReward)
	{
	}

	public static RangeValidator<int> GetXPRewardRangeValidator(GamePassTier tier)
	{
		return null;
	}
}
