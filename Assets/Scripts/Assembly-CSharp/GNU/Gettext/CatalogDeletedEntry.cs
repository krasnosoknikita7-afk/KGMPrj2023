using System.Collections.Generic;

namespace GNU.Gettext
{
	public class CatalogDeletedEntry
	{
		private List<string> deletedLines;

		private List<string> references;

		private List<string> autocomments;

		private string flags;

		private string comment;

		public string[] DeletedLines => null;

		public string[] References => null;

		public string Comment => null;

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

		public CatalogDeletedEntry(string[] deletedLines)
		{
		}

		public CatalogDeletedEntry(CatalogDeletedEntry dt)
		{
		}

		public void AddReference(string reference)
		{
		}

		public void ClearReferences()
		{
		}

		public void SetDeletedLines(string[] lines)
		{
		}

		public void SetComment(string comment)
		{
		}

		public void AddAutoComments(string comment)
		{
		}

		public void ClearAutoComments()
		{
		}
	}
}
