using System;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogHandler : MonoBehaviour
{
	private class StatHatErrorCount
	{
		private bool reportedError;

		private bool reportedOngoingError;

		public void Increment(bool errorDetected, bool onGoingErrorDetected)
		{
		}

		private void IncrementErrorCountOnGoing()
		{
		}

		private void IncrementErrorCount()
		{
		}
	}

	private const int maxErrorBeforeReport = 50;

	private const int sampleErrorFrequency = 100;

	private static List<string> sanitizeLogSubstrings;

	private static HashSet<string> ignoreLogStrings;

	private int maxLogContextQueueCount;

	private ProxyLogHandler kogamaLogHandler;

	private StatHatErrorCount statHatErrorCount;

	[SerializeField]
	private SentrySdk sentrySdk;

	private int timeFrameCount;

	private int errorCount;

	private bool logErrorHasBeenSendOnce;

	private Queue<Dictionary<string, object>> logContextQueue;

	private string sanitizedString;

	private bool isSampling;

	private bool isInBrokenState;

	private static bool didConnectToGameServer;

	private static string firstError;

	public static bool DidConnectToGameServer
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool SendOnGoingError => false;

	private bool AlwaysSampling => false;

	public void Initialize(DebugLogHandlerConfig debugLogHandlerConfig, SentryConfig sentryConfig)
	{
	}

	private void KogamaLogHandlerOnOnLogReceived(object sender, ProxyLogHandler.LogFormatData e)
	{
	}

	public void Destroy()
	{
	}

	private void HandleLog(string logString, string stackTrace, LogType type)
	{
	}

	private static string CleanStackTrace(string stackTrace)
	{
		return null;
	}

	private void HandleLogExecute(string logString, string stackTrace, LogType type)
	{
	}

	private void ReportError(string logString, string stackTrace, LogType type)
	{
	}

	private string SanitizeLogStringForUniqueErrors(string logString)
	{
		return null;
	}

	private static void SendToConsole(string logString, string stackTrace)
	{
	}

	private static bool IsIgnored(string logString)
	{
		return false;
	}

	private bool AddLogToLogContext(string logString, LogType type)
	{
		return false;
	}

	private void Update()
	{
	}

	private Dictionary<string, object> GetExtraSentryData()
	{
		return null;
	}

	private static Dictionary<string, string> GetTags()
	{
		return null;
	}

	private static string GetIsTouristSession()
	{
		return null;
	}

	private static string GetPlanetID()
	{
		return null;
	}

	private static string GetProfileID()
	{
		return null;
	}

	private static string GetGameMode()
	{
		return null;
	}

	private static string GetJoinState()
	{
		return null;
	}

	private static string GetPlayersCount()
	{
		return null;
	}

	private static string GetPendingPlayersCount()
	{
		return null;
	}

	private static string TryGetExtraString(Func<string> getFunc)
	{
		return null;
	}

	private static string GetSystemInfo()
	{
		return null;
	}

	private static string GenerateSystemInfoString(Dictionary<string, string> systemInfo)
	{
		return null;
	}

	private string GetLogContext()
	{
		return null;
	}

	private static string GetBrowserInfo()
	{
		return null;
	}
}
