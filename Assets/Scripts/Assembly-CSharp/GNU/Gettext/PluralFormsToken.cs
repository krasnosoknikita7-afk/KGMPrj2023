namespace GNU.Gettext
{
	internal class PluralFormsToken
	{
		public enum Type
		{
			Error = 0,
			Eof = 1,
			Number = 2,
			N = 3,
			Plural = 4,
			Nplurals = 5,
			Equal = 6,
			Assign = 7,
			Greater = 8,
			GreaterOrEqual = 9,
			Less = 10,
			LessOrEqual = 11,
			Reminder = 12,
			NotEqual = 13,
			LogicalAnd = 14,
			LogicalOr = 15,
			Question = 16,
			Colon = 17,
			Semicolon = 18,
			LeftBracket = 19,
			RightBracket = 20
		}

		private Type type;

		private int number;

		public Type TokenType
		{
			get
			{
				return Type.Error;
			}
			set
			{
			}
		}

		public int Number
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public PluralFormsToken()
		{
		}

		public PluralFormsToken(PluralFormsToken src)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
