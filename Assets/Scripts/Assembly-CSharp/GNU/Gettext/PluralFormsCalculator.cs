namespace GNU.Gettext
{
	public class PluralFormsCalculator
	{
		private int nplurals;

		private PluralFormsNode plural;

		private string expression;

		public int NPlurals => 0;

		public PluralFormsCalculator(string expression)
		{
		}

		public long Evaluate(long n, bool traceToFile)
		{
			return 0L;
		}

		public long Evaluate(long n)
		{
			return 0L;
		}

		public static PluralFormsCalculator Make(string str)
		{
			return null;
		}

		public void DumpNodes(string fileName)
		{
		}

		internal void Init(int nplurals, PluralFormsNode plural)
		{
		}
	}
}
