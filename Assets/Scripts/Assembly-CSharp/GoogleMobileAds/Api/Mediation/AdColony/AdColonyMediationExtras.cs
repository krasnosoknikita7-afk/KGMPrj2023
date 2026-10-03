namespace GoogleMobileAds.Api.Mediation.AdColony
{
	public class AdColonyMediationExtras : MediationExtras
	{
		public const string ShowPrePopupKey = "show_pre_popup";

		public const string ShowPostPopupKey = "show_post_popup";

		public override string AndroidMediationExtraBuilderClassName => null;

		public override string IOSMediationExtraBuilderClassName => null;

		public void SetShowPrePopup(bool showPrePopup)
		{
		}

		public void SetShowPostPopup(bool showPostPopup)
		{
		}
	}
}
