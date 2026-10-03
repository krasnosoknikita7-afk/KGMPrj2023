public static class BrowserCommGotoRequests
{
	private struct Options
	{
		public bool openInNewTab;

		public bool openInModal;

		public Options(bool newTab = false, bool modalPopup = false)
		{
			openInNewTab = false;
			openInModal = false;
		}
	}

	private const string eliteUpgrade = "goToEliteUpgrade_v2";

	private const string purchaseGold = "gotoPurchaseGold_v2";

	private const string playerProfile = "gotoPlayerProfile_v2";

	private const string login = "gotoLogin_v2";

	private const string signup = "gotoSignup_v2";

	private const string signout = "gotoSignout";

	private const string idle = "gotoIdlePage";

	private const string disconnected = "gotoDisconnectedPage";

	public static void GotoPurchaseGold(bool newTab = false, bool modalPopup = false)
	{
	}

	public static void GotoEliteUpgrade(bool newTab = false, bool modalPopup = false)
	{
	}

	public static void GotoPlayerProfile(int profileId, bool newTab = false, bool modalPopup = false)
	{
	}

	public static void GotoLogin(bool newTab = false, bool modalPopup = false)
	{
	}

	public static void GotoMainpage(bool newTab = false, bool modalPopup = false)
	{
	}

	public static void GotoURL(string URL, bool newTab = false, bool modalPopup = false)
	{
	}

	public static void GotoSignup(bool newTab = false, bool modalPopup = false)
	{
	}

	public static void GotoSignout()
	{
	}

	public static void GotoIdle()
	{
	}

	public static void GotoDisconnected()
	{
	}
}
