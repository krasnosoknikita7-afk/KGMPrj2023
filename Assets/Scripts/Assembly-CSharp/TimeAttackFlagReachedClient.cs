public class TimeAttackFlagReachedClient : TimeAttackFlagReached, IWinningConditionBriefing
{
	public TimeAttackFlagReachedClient(WinningCondition parent, int id, GameStatCounterManager gameCounterManager)
		: base(null, 0, null)
	{
	}

	public void GetBriefing(IBriefing winningConditionBriefingView)
	{
	}

	public void GetDebriefing(IDebriefing winningConditionDebriefingView)
	{
	}
}
