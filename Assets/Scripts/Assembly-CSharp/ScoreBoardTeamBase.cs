using UnityEngine;

public class ScoreBoardTeamBase : ScoreBoardBase
{
	public override void Initialize(GameStatCounterType statType)
	{
	}

	public override void OnStatsChange(int actorNumber, int scoreCount)
	{
	}

	public override void ReSortScoreBoard()
	{
	}

	protected override void UnSubscribeToCallbacks()
	{
	}

	private void AddTeamsToScoreBoard()
	{
	}

	protected override Color GetBackgroundColor(int teamId)
	{
		return default;
	}

	protected override void HandleParticipantListChanged()
	{
	}

	protected override bool IsNewScoreBetter(int newScore, int oldScore, int newId, int oldId)
	{
		return false;
	}
}
