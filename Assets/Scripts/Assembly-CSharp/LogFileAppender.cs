using System.IO;

public class LogFileAppender : IAppender
{
	private FileStream fs;

	private StreamWriter writer;

	public LogFileAppender(string filename)
	{
	}

	public void Log(string loggerName, string message)
	{
	}

	~LogFileAppender()
	{
	}
}
