using UnityEngine;

public class ScoreBoardController : MonoBehaviour
{
	[SerializeField]
	private ScoreBoardSingleBase scoreboardSingle;

	[SerializeField]
	private ScoreBoardTeamBase scoreboardTeam;

	public ScoreBoardBase GetInstantiatedScoreboard(WinningConditionType winConType)
	{
		return null;
	}
}
