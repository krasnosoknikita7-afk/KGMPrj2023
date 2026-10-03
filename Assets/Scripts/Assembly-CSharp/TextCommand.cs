public static class TextCommand
{
	private class Command
	{
		private string[] commandComponents;

		public string Name => null;

		public int ArgCount => 0;

		private Command(string[] commandComponents)
		{
		}

		public string Arg(int i)
		{
			return null;
		}

		public static implicit operator Command(string commandLine)
		{
			return null;
		}
	}

	public static void Resolve(string commandLine)
	{
	}

	private static void Command_AssetBundleCacheTest(Command command)
	{
	}

	private static void Command_Invalid(Command command)
	{
	}

	public static void NotifyUser(string msg)
	{
	}
}
