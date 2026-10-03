using GoogleMobileAds.Common.Mediation.AppLovin;

namespace GoogleMobileAds.Api.Mediation.AppLovin
{
	public class AppLovin
	{
		private static readonly IAppLovinClient client;

		public static void Initialize()
		{
		}

		public static void SetHasUserConsent(bool hasUserConsent)
		{
		}

		public static void SetIsAgeRestrictedUser(bool isAgeRestrictedUser)
		{
		}

		public static void SetDoNotSell(bool doNotSell)
		{
		}

		private static IAppLovinClient GetAppLovinClient()
		{
			return null;
		}
	}
}
