using System.Collections.Generic;

namespace GNU.Gettext
{
	internal static class IsoCodes
	{
		internal class IsoCode
		{
			private string iso;

			private string name;

			public string Iso => null;

			public string Name => null;

			public IsoCode(string iso, string name)
			{
			}
		}

		private static IDictionary<string, IsoCode> isoLanguagesByCode;

		private static IDictionary<string, IsoCode> isoLanguagesByLang;

		private static IDictionary<string, IsoCode> isoCountriesByCode;

		private static IDictionary<string, IsoCode> isoCountriesByCountry;

		public static IEnumerable<IsoCode> KnownLanguages => null;

		public static IEnumerable<IsoCode> KnownCountries => null;

		static IsoCodes()
		{
		}

		public static IsoCode LookupLanguageCode(string code)
		{
			return null;
		}

		public static IsoCode LookupCountryCode(string code)
		{
			return null;
		}

		public static bool IsKnownLanguageCode(string code)
		{
			return false;
		}

		public static bool IsKnownCountryCode(string code)
		{
			return false;
		}
	}
}
