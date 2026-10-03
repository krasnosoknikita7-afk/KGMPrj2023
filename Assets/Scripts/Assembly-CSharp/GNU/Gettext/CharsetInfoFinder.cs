namespace GNU.Gettext
{
	internal class CharsetInfoFinder : CatalogParser
	{
		private string charset;

		public string Charset => null;

		public CharsetInfoFinder(string text)
			: base(null, null)
		{
		}

		protected override bool OnEntry(string msgid, string msgidPlural, bool hasPlural, string[] translations, string flags, string[] references, string comment, string[] autocomments, string msgctxt)
		{
			return false;
		}
	}
}
