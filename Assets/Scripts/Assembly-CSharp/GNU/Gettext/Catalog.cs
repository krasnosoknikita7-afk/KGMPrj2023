using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GNU.Gettext
{
	public class Catalog : IEnumerable<CatalogEntry>, IEnumerable
	{
		private IDictionary<string, CatalogEntry> entriesDict;

		private List<CatalogEntry> entriesList;

		private List<CatalogDeletedEntry> deletedEntriesList;

		private bool isOk;

		private bool isDirty;

		private string fileName;

		public const string PluralFormsHeader = "Plural-Forms";

		[CompilerGenerated]
		private EventHandler m_DirtyChanged;

		private Dictionary<string, string> headerEntries;

		public string Project;

		public string CreationDate;

		public string RevisionDate;

		public string Translator;

		public string TranslatorEmail;

		public string Team;

		public string TeamEmail;

		public string Charset;

		public string Language;

		public string Country;

		public string Comment;

		public bool IsDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Count => 0;

		public CatalogEntry this[int index] => null;

		public int PluralFormsCount => 0;

		public string[] PluralFormsDescriptions => null;

		public bool IsOk => false;

		public string LocaleCode => null;

		public bool HasDeletedItems => false;

		public string CommentForGui
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event EventHandler DirtyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public string GetPluralFormsHeader()
		{
			return null;
		}

		private static string GetDateTimeRfc822Format()
		{
			return null;
		}

		private static void FormatMessageForFile(StringBuilder sb, string prefix, string message, string newlineChar)
		{
		}

		private void Clear()
		{
		}

		public void Load(string text, string fileName)
		{
		}

		private static string EnsureCorrectEndings(string reference, string text)
		{
			return null;
		}

		private static void SaveMultiLines(StringBuilder sb, string text, string newLine)
		{
		}

		private static bool CanEncodeToCharset(string charset)
		{
			return false;
		}

		private static Encoding GetEncoding(string charset)
		{
			return null;
		}

		public bool Translate(string msgid, string context, string translation)
		{
			return false;
		}

		public CatalogEntry FindItem(string msgid, string context)
		{
			return null;
		}

		public bool Contains(string msgid, string context)
		{
			return false;
		}

		public CatalogEntry FindItem(CatalogEntry entry)
		{
			return null;
		}

		public CatalogEntry AddItem(string original, string plural)
		{
			return null;
		}

		public void GetStatistics(out int all, out int fuzzy, out int missing, out int badtokens, out int untranslated)
		{
			all = default;
			fuzzy = default;
			missing = default;
			badtokens = default;
			untranslated = default;
		}

		public void Append(Catalog catalog)
		{
		}

		public void AddItem(CatalogEntry data)
		{
		}

		public void RemoveItem(CatalogEntry data)
		{
		}

		public void AddDeletedItem(CatalogDeletedEntry data)
		{
		}

		public void RemoveDeletedItems()
		{
		}

		public void GetMergeSummary(Catalog refCat, out string[] newEntries, out string[] obsoleteEntries)
		{
			newEntries = null;
			obsoleteEntries = null;
		}

		protected virtual void OnDirtyChanged(EventArgs e)
		{
		}

		private void CreateNewHeaders()
		{
		}

		public void ParseHeaderString(string headers)
		{
		}

		public string GetHeaderString(string lineDelimeter)
		{
			return null;
		}

		public string GetHeaderString()
		{
			return null;
		}

		public void UpdateHeaderDict()
		{
		}

		private void ParseHeaderDict()
		{
		}

		public string GetHeader(string key)
		{
			return null;
		}

		public bool HasHeader(string key)
		{
			return false;
		}

		public void SetHeader(string key, string value)
		{
		}

		public void SetHeaderNotEmpty(string key, string value)
		{
		}

		public void DeleteHeader(string key)
		{
		}

		public IEnumerator<CatalogEntry> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
