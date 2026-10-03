using System;
using System.Collections.Generic;

namespace Localize
{
	public class EnumLocalizeBookkeeping
	{
		private Dictionary<int, string> enumToStringKeyMap;

		private Action<Dictionary<int, string>> initCallback;

		public EnumLocalizeBookkeeping(Action<Dictionary<int, string>> initCallback)
		{
		}

		public string GetLocalizedString(int enumVal)
		{
			return null;
		}

		private void Init()
		{
		}
	}
}
