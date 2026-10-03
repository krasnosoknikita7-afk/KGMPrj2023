using System.Collections.Generic;
using ExitGames.Client.Photon;
using MV.Common;

public class GameSessionData
{
	public const string DataServerIP = "serverIP";

	public const string DataProfileID = "profileID";

	public const string DataPlanetID = "planetID";

	public const string DataGameMode = "gameMode";

	public const string DataLanguage = "language";

	public const string DataToken = "token";

	public const string DataSessionToken = "sessionToken";

	public string serverIP;

	public int profileID;

	public int planetID;

	public MVGameMode gameMode;

	public string language;

	public bool embedded;

	public string token;

	public string sessionToken;

	public string newPlanetName;

	public string pingURL;

	public string disconnectURL;

	public string gameRewardURL;

	public string gamePublishedURL;

	public string purchaseGoldURL;

	public string loginURL;

	public string signupURL;

	public string idleURL;

	public string disconnectedURL;

	public string playerProfileURL;

	public string eliteUpgradeURL;

	public string region;

	public string ezKey;

	public string reauthURL;

	public string gameRewardDataURL;

	public string referrer;

	public bool detailedStats;

	public bool playButtonAdsEnabledDefault;

	public bool boostersEnabledDefault;

	public bool interstitialsAdsEnabledDefault;

	public bool rewardedAdsEnabledDefault;

	public ConnectionProtocol ConnectionProtocol => ConnectionProtocol.Udp;

	public GameSessionData()
	{
	}

	public GameSessionData(Dictionary<string, object> gameSessionData)
	{
	}

	public bool GetIsRedirectAllowed()
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
