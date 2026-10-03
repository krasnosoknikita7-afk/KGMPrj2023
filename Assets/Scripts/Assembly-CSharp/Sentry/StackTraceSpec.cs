using System;

namespace Sentry
{
	[Serializable]
	public class StackTraceSpec
	{
		public string filename;

		public string function;

		public string module;

		public int lineno;

		public bool in_app;

		public StackTraceSpec(string filename, string function, int lineNo, bool inApp)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
