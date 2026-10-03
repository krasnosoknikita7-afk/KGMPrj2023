public static class StatHatWrapper
{
	private static bool isFirstTimeSession;

	private const string allBtFormat = "{0}.u.{1}";

	private const string allBtFormatFtsStats = "{0}.u.fts.{1}";

	private const string ezKey = "h5g9REtmi1LT7JY5";

	private const string btFormat = "{0}.u.standalone.{1}";

	private const string btFormatFtsStats = "{0}.u.fts.standalone.{1}";

	private static StatHatConfig statHatConfig;

	public static void Initialize(bool isFirstTimeSession, StatHatConfig statHatConfig)
	{
	}

	public static void Count(string key, int count)
	{
	}

	public static void Value(string key, int value)
	{
	}

	public static void Value(string key, float value)
	{
	}

	private static void Count(string allBtKey, string btKey, int count)
	{
	}

	private static void Value(string allBtKey, string btKey, int value)
	{
	}

	private static void Value(string allBtKey, string btKey, float value)
	{
	}
}
