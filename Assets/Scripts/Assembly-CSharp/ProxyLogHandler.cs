using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ProxyLogHandler : ILogHandler
{
	public class LogFormatData : EventArgs
	{
		public LogType LogType;

		public UnityEngine.Object context;

		public string format;

		public object[] args;

		public string Message => null;

		public LogFormatData(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}
	}

	private ILogHandler defaultLogHandler;

	[CompilerGenerated]
	private EventHandler<LogFormatData> m_OnLogReceived;

	public LogType filterLogTypeConsoleWrite;

	public event EventHandler<LogFormatData> OnLogReceived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private bool isAllowed(LogType logType)
	{
		return false;
	}

	public void Disable()
	{
	}

	public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
	{
	}

	public void LogException(Exception exception, UnityEngine.Object context)
	{
	}
}
