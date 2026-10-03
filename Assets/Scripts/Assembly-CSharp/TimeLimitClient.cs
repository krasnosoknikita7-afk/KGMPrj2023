public class TimeLimitClient : TimeLimit, IWinningConditionBriefing
{
	public override bool IsBriefingNode => false;

	public TimeLimitClient(WinningCondition parent, int id, GameStatCounterManager gameCounterManager)
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
