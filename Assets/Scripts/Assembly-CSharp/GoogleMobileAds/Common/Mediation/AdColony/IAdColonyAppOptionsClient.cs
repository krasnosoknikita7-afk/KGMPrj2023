using GoogleMobileAds.Api.Mediation.AdColony;

namespace GoogleMobileAds.Common.Mediation.AdColony
{
	public interface IAdColonyAppOptionsClient
	{
		void SetPrivacyFrameworkRequired(AdColonyPrivacyFramework privacyFramework, bool required);

		bool GetPrivacyFrameworkRequired(AdColonyPrivacyFramework privacyFramework);

		void SetPrivacyConsentString(AdColonyPrivacyFramework privacyFramework, string consentString);

		string GetPrivacyConsentString(AdColonyPrivacyFramework privacyFramework);

		void SetUserId(string userId);

		string GetUserId();

		void SetTestMode(bool isTestMode);

		bool IsTestMode();
	}
}
