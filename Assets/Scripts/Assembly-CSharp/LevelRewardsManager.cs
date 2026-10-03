using System;
using System.Collections.Generic;

public class LevelRewardsManager
{
	private Dictionary<int, int> unseenLevelRewards;

	public Action OnRewardsReturned;

	public Dictionary<int, int> RewardsToShow => null;

	public KeyValuePair<int, int> NextReward { get; private set; }

	public void ClearRewards()
	{
	}

	public void SetNextLevelReward(int level, int gold)
	{
	}

	public void AddClaimedLevelRewards(Dictionary<int, int> levelRewards)
	{
	}
}
