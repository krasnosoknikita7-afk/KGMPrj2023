using GoogleMobileAds.Api.Mediation.Vungle;

namespace GoogleMobileAds.Common.Mediation.Vungle
{
	public interface IVungleClient
	{
		void UpdateConsentStatus(VungleConsentStatus consentStatus, string consentMessageVersion);

		void UpdateCCPAStatus(VungleCCPAStatus consentStatus);
	}
}
