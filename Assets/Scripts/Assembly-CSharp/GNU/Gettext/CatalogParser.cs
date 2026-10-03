using System.IO;
using System.Text;

namespace GNU.Gettext
{
	public abstract class CatalogParser
	{
		internal static readonly string[] LineSplitStrings;

		public string NewLine { get; private set; }

		public CatalogParser(string text, Encoding encoding)
		{
		}

		private static string GetNewLine(string text, Encoding encoding)
		{
			return null;
		}

		private static bool ReadParam(string input, string pattern, out string output)
		{
			output = null;
			return false;
		}

		private string ParseMessage(ref string line, ref string dummy, StringReader sr)
		{
			return null;
		}

		public bool Parse(string text)
		{
			return false;
		}

		protected abstract bool OnEntry(string msgid, string msgidPlural, bool hasPlural, string[] translations, string flags, string[] references, string comment, string[] autocomments, string msgctxt);

		protected virtual bool OnDeletedEntry(string[] deletedLines, string flags, string[] references, string comment, string[] autocomments)
		{
			return false;
		}
	}
}
