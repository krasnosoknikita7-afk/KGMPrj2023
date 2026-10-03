using System;

public static class GamePointGainEffectManager
{
	public static Action<int> OnGamePointGainEffectShown;

	public static Action<int> OnInGamePointGainEffectShown;

	public static Action<int> OnTierProgressBarGamePointGainEffectShown;

	private static int progressBarGamePointAmountShown;

	public static int GamePointAmountShown => 0;

	public static void HaveShownGamePointGainEffect(int gamePointAmountShown)
	{
	}

	public static void HaveShownInGamePointGainEffect(int gamePointAmountShown)
	{
	}

	public static void HaveShownTierProgressBarGamePointGainEffect(int gamePointAmountShown)
	{
	}

	public static void PostResetCleanup()
	{
	}
}
