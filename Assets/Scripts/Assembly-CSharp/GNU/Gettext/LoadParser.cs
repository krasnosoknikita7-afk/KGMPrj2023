using System.Text;

namespace GNU.Gettext
{
	internal class LoadParser : CatalogParser
	{
		private Catalog catalog;

		private bool headerParsed;

		public LoadParser(Catalog catalog, string text, Encoding encoding)
			: base(null, null)
		{
		}

		protected override bool OnEntry(string msgid, string msgidPlural, bool hasPlural, string[] translations, string flags, string[] references, string comment, string[] autocomments, string msgctxt)
		{
			return false;
		}

		protected override bool OnDeletedEntry(string[] deletedLines, string flags, string[] references, string comment, string[] autocomments)
		{
			return false;
		}
	}
}
