public class OculusKillLimitClient : OculusKillLimit, IWinningConditionBriefing
{
	public OculusKillLimitClient(WinningCondition parent, int id, GameStatCounterManager gameCounterManager, int killLimit)
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
