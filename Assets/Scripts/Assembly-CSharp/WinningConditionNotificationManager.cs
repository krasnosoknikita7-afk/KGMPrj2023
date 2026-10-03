using System.Collections.Generic;
using MV.Common;

public static class WinningConditionNotificationManager
{
	public static void UpdateNotification(int actorNumber, GameStatCounterType counterType, int scoreCount)
	{
	}

	public static void SendNotification(NotificationType type, Dictionary<object, object> data)
	{
	}

	private static int GetScoreLeftToWin(GameStatCounterType counterType, int scoreCount)
	{
		return 0;
	}

	private static bool ShouldShowNotification(int actorNumber, GameStatCounterType counterType, int scoreLeftToWin, out NotificationType notificationType)
	{
		notificationType = default;
		return false;
	}

	private static string GenerateNotificationText(int actorNumber, GameStatCounterType counterType, int scoreLeftToWin)
	{
		return null;
	}

	private static string GetContestantName(int actorNumber)
	{
		return null;
	}

	private static string GetPlayerName(int actorNumber)
	{
		return null;
	}

	private static bool IsFlagScoreBestInGame(int score, int actorNumber)
	{
		return false;
	}

	private static int GetPlayerRanking(GameStatCounterType statType, int actorNumber, int score)
	{
		return 0;
	}
}
