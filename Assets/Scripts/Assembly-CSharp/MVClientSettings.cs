using MV.Common;

public static class MVClientSettings
{
	private static ClientSettingFlags flags;

	private static bool flagsSet;

	public static ClientSettingFlags ClientSettingFlags
	{
		get
		{
			return ClientSettingFlags.None;
		}
		set
		{
		}
	}

	public static int PostGameInterstitialIntervalInSeconds { get; set; }

	public static int ReviveFlags { get; set; }

	public static bool TouristChatAllowed => false;

	public static bool EnableSentry => false;

	public static bool ShowTouristPromotion => false;

	public static bool SpinEnabled => false;

	public static bool PostGameInterstitialEnabled => false;

	public static bool SeekAdConsent => false;

	public static bool JoinFlowAdsEnabled => false;

	public static bool WebAdSDKsEnabled => false;

	public static bool GameDistributionAdsEnabled => false;

	public static bool PokiAdsEnabled => false;

	public static bool CrazyAdsEnabled => false;

	public static bool PlayButtonAdsRegisteredUsers => false;

	public static bool FirstPreviewTierFreeEnabled => false;

	public static bool ReviveEnabled => false;

	public static bool PlayButtonAdsEnabled => false;

	public static bool BoostersEnabled => false;

	public static bool InterstitialsAdsEnabled => false;

	public static bool RewardedAdsEnabled => false;

	public static bool EnableStathat => false;

	public static bool IsSubscriber => false;

	public static bool IsFlagSet(ClientSettingFlags flag)
	{
		return false;
	}

	private static bool IsReviveFlagEnabledForSessionType()
	{
		return false;
	}
}
