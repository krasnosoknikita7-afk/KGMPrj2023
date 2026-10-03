namespace GNU.Gettext
{
	internal class PluralFormsScanner
	{
		private string str;

		private int pos;

		private PluralFormsToken token;

		public PluralFormsToken Token => null;

		public PluralFormsScanner(string str)
		{
		}

		public bool NextToken()
		{
			return false;
		}
	}
}
