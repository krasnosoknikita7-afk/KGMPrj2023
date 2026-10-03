using GoogleMobileAds.Api.Mediation.Vungle;

namespace GoogleMobileAds.Common.Mediation.Vungle
{
	public class DummyClient : IVungleClient
	{
		public void UpdateConsentStatus(VungleConsentStatus consentStatus, string consentMessageVersion)
		{
		}

		public void UpdateCCPAStatus(VungleCCPAStatus consentStatus)
		{
		}
	}
}
