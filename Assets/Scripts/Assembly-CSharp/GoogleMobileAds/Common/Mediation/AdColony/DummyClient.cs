using GoogleMobileAds.Api.Mediation.AdColony;

namespace GoogleMobileAds.Common.Mediation.AdColony
{
	public class DummyClient : IAdColonyAppOptionsClient
	{
		public void SetPrivacyFrameworkRequired(AdColonyPrivacyFramework privacyFramework, bool isRequired)
		{
		}

		public bool GetPrivacyFrameworkRequired(AdColonyPrivacyFramework privacyFramework)
		{
			return false;
		}

		public void SetPrivacyConsentString(AdColonyPrivacyFramework privacyFramework, string consentString)
		{
		}

		public string GetPrivacyConsentString(AdColonyPrivacyFramework privacyFramework)
		{
			return null;
		}

		public void SetUserId(string userId)
		{
		}

		public string GetUserId()
		{
			return null;
		}

		public void SetTestMode(bool isTestMode)
		{
		}

		public bool IsTestMode()
		{
			return false;
		}
	}
}
