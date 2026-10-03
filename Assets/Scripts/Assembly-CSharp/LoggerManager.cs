using System;
using System.Collections.Generic;

public class LoggerManager
{
	public class Logger : ILogger
	{
		private LoggerManager manager;

		private readonly string name;

		public Logger(LoggerManager manager, string name)
		{
		}

		public void Log(string message)
		{
		}
	}

	private static LoggerManager instance;

	private Dictionary<string, Logger> loggers;

	private HashSet<string> interestingLoggers;

	private bool appendAll;

	private IAppender appender;

	public static LoggerManager Instance => null;

	private LoggerManager()
	{
	}

	public static void Destroy()
	{
	}

	private void ApplySettingsFromIniFile()
	{
	}

	public ILogger GetLogger(Type type)
	{
		return null;
	}

	public ILogger GetLogger(string name)
	{
		return null;
	}

	private void Log(string loggerName, string message)
	{
	}
}
