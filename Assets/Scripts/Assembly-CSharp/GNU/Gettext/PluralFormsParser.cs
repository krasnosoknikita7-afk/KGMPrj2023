namespace GNU.Gettext
{
	internal class PluralFormsParser
	{
		private PluralFormsScanner scanner;

		private PluralFormsToken Token => null;

		public PluralFormsParser(PluralFormsScanner scanner)
		{
		}

		public bool Parse(PluralFormsCalculator calculator)
		{
			return false;
		}

		private PluralFormsNode ParsePlural()
		{
			return null;
		}

		private bool NextToken()
		{
			return false;
		}

		private PluralFormsNode Expression()
		{
			return null;
		}

		private PluralFormsNode LogicalOrExpression()
		{
			return null;
		}

		private PluralFormsNode LogicalAndExpression()
		{
			return null;
		}

		private PluralFormsNode EqualityExpression()
		{
			return null;
		}

		private PluralFormsNode MultiplicativeExpression()
		{
			return null;
		}

		private PluralFormsNode RelationalExpression()
		{
			return null;
		}

		private PluralFormsNode PmExpression()
		{
			return null;
		}
	}
}
