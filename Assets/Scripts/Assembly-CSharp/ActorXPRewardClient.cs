using MV.Common;

public class ActorXPRewardClient : IActorRewardClient
{
	public int xpAmount;

	public RewardType RewardType { get; set; }

	public RewardRarity RewardRarity { get; set; }

	public override string ToString()
	{
		return null;
	}
}
