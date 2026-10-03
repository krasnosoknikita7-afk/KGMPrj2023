using System;
using System.Collections.Generic;

namespace Sentry
{
	[Serializable]
	public class SentryEvent
	{
		public string event_id;

		public string message;

		public string timestamp;

		public string logger;

		public string level;

		public string platform;

		public string release;

		public Context contexts;

		public SdkVersion sdk;

		public List<Breadcrumb> breadcrumbs;

		public Dictionary<string, string> tags;

		public Dictionary<string, object> extra;

		public SentryEvent(string message, Dictionary<string, string> tags, Dictionary<string, object> extra, List<Breadcrumb> breadcrumbs = null)
		{
		}
	}
}
