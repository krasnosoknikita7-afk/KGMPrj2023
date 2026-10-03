using System;

namespace Sentry
{
	[Serializable]
	public class Context
	{
		public App app;

		public Gpu gpu;

		public OperatingSystem os;

		public Device device;
	}
}
