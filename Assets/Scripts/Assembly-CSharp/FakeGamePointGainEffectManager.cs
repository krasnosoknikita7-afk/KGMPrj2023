using System;

public static class FakeGamePointGainEffectManager
{
	public static Action<int> OnFakeGamePointGainEffect;

	public static void FakeGainEffect(int amountOfGamePoints)
	{
	}

	private static bool ShouldShowFakeGainEffect()
	{
		return false;
	}
}
