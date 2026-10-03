using System.Collections.Generic;

namespace GNU.Gettext
{
	public class CatalogEntry
	{
		public enum Validity
		{
			Unknown = 0,
			Invalid = 1,
			Valid = 2
		}

		private string str;

		private string plural;

		private bool hasPlural;

		private List<string> translations;

		private List<string> references;

		private List<string> autocomments;

		private bool isFuzzy;

		private bool isModified;

		private bool isAutomatic;

		private bool hasBadTokens;

		private string moreFlags;

		private string comment;

		private Validity validity;

		private string errorString;

		private string context;

		private Catalog owner;

		public string String => null;

		public bool HasPlural => false;

		public string PluralString => null;

		public int NumberOfTranslations => 0;

		public int TranslationsCount => 0;

		public string Context
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasContext => false;

		public string Key => null;

		public string[] References => null;

		public string Comment
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] AutoComments => null;

		public bool HasComment => false;

		public string Flags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsFuzzy
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsTranslated => false;

		public bool IsModified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsAutomatic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Validity DataValidity
		{
			get
			{
				return Validity.Unknown;
			}
			set
			{
			}
		}

		public string ErrorString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string LocaleCode => null;

		public CatalogEntry(Catalog owner, string str, string plural)
		{
		}

		public CatalogEntry(Catalog owner, CatalogEntry dt)
		{
		}

		public string GetTranslation(int index)
		{
			return null;
		}

		public static string MakeKey(string msgid, string context)
		{
			return null;
		}

		public void AddReference(string reference)
		{
		}

		public void ClearReferences()
		{
		}

		public bool RemoveReferenceTo(string fileNamePrefix)
		{
			return false;
		}

		public void RemoveReference(string reference)
		{
		}

		public void SetString(string str)
		{
		}

		public void SetPluralString(string plural)
		{
		}

		public void SetTranslation(string translation, int index)
		{
		}

		public void SetTranslations(string[] translations)
		{
		}

		public bool IsInFormat(string format)
		{
			return false;
		}

		public void AddAutoComment(string comment, bool ifNotExists)
		{
		}

		public void AddAutoComment(string comment)
		{
		}

		public void ClearAutoComments()
		{
		}

		private void MarkOwnerDirty()
		{
		}
	}
}
