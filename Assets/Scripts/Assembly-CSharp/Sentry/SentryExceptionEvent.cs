using System.Collections.Generic;

namespace Sentry
{
	public class SentryExceptionEvent : SentryEvent
	{
		public ExceptionContainer exception;

		public SentryExceptionEvent(string exceptionType, string exceptionValue, List<Breadcrumb> breadcrumbs, List<StackTraceSpec> stackTrace, Dictionary<string, string> tags, Dictionary<string, object> extra)
			: base(null, null, null)
		{
		}
	}
}
