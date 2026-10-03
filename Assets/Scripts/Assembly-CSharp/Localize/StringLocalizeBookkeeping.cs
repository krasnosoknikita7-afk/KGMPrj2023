using System;
using System.Collections.Generic;

namespace Localize
{
	public class StringLocalizeBookkeeping
	{
		private Dictionary<string, string> stringToStringKeyMap;

		private Action<Dictionary<string, string>> initCallback;

		public StringLocalizeBookkeeping(Action<Dictionary<string, string>> initCallback)
		{
		}

		public string GetLocalizedString(string stringVal)
		{
			return null;
		}

		private void Init()
		{
		}
	}
}
