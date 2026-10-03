namespace GoogleMobileAds.Common.Mediation.IronSource
{
	public interface IIronSourceClient
	{
		void SetConsent(bool consent);

		void SetMetaData(string key, string metaDataValue);
	}
}
