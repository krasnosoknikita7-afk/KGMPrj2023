public static class PlayerPrefsManager
{
	private const string signInStateKey = "signInState";

	private static bool playerHasChangedFromTouristToRegistered;

	private static bool isReturningPlayer;

	private const string playedGamesListKey = "playedGamesList";

	private const int maxPlayGamesListCount = 50;

	private static bool isFirstTimeSession;

	private const string isFirstTimeSessionKey = "isFirstTimeSession";

	public static bool IsFirstTimeSession => false;

	public static bool IsReturningAsSignedUp => false;

	public static bool IsReturningPlayer => false;

	private static void HandleSignInState(bool isRegistered)
	{
	}

	public static void EarlyInitialize()
	{
	}

	public static void Initialize(GameSessionData gameSessionData)
	{
	}

	private static void HandlePlayedGames(int gameId)
	{
	}
}
