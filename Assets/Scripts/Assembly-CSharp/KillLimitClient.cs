public class KillLimitClient : KillLimit, IWinningConditionBriefing
{
	public KillLimitClient(WinningCondition parent, int id, GameStatCounterManager gameCounterManager, int killLimit)
		: base(null, 0, null, 0)
	{
	}

	public void GetBriefing(IBriefing winningConditionBriefingView)
	{
	}

	public void GetDebriefing(IDebriefing winningConditionDebriefingView)
	{
	}
}
