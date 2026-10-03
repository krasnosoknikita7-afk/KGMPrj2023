using System;
using System.Collections.Generic;

namespace Sentry
{
	[Serializable]
	public class Breadcrumb
	{
		public const int MaxBreadcrumbs = 100;

		public string timestamp;

		public string message;

		public Breadcrumb(string timestamp, string message)
		{
		}

		public static List<Breadcrumb> CombineBreadcrumbs(Breadcrumb[] breadcrumbs, int index, int number)
		{
			return null;
		}
	}
}
