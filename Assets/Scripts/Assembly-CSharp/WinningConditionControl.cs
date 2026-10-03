using UnityEngine;

public class WinningConditionControl : MonoBehaviour
{
	public static bool TryGetPrioritizedWinCondition(out WinningConditionType condition)
	{
		condition = default;
		return false;
	}

	public static bool TryGetPrioritizedStat(out GameStatCounterType statType)
	{
		statType = default;
		return false;
	}

	public static int GetPrioritizedStatLimit(GameStatCounterType gameStatType)
	{
		return 0;
	}

	public static bool IsNewScoreBetter(int newScore, int oldScore, GameStatCounterType statType)
	{
		return false;
	}

	public static string MakeIntoScoreText(int score, GameStatCounterType statType)
	{
		return null;
	}
}
