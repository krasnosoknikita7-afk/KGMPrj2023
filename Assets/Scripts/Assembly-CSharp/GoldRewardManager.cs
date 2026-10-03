using MV.Common;

public class GoldRewardManager
{
	private bool isGoldRewardGame;

	private bool isCountingDownGoldReward;

	private bool isGoldRewardDone;

	private float startTime;

	public bool IsGoldRewardGame => false;

	public bool IsCountingDownGoldReward => false;

	public bool IsGoldRewardDone => false;

	public void Initialize(bool isGoldRewardGame)
	{
	}

	public void StartGoldRewardCountdownWhenReady()
	{
	}

	public float GetGoldRewardTimeLeft()
	{
		return 0f;
	}

	public float GetGoldRewardCountdownProgressPercentage()
	{
		return 0f;
	}

	public void OnClaimGoldReward()
	{
	}

	public bool CanGetGoldReward()
	{
		return false;
	}

	private void OnAvatarChangeState(SpawnRoleModeType avatarMode)
	{
	}

	private void StartGoldRewardCountdown()
	{
	}
}
