using System;
using System.Collections.Generic;
using UnityEngine;

public class BrowserComm : MonoBehaviour
{
	private class JsonGoldUpdateData
	{
		public int goldAmountDelta;

		public int currentGold;
	}

	private class JsonReturnData
	{
		public int callbackId;

		public string data;

		public string error;

		public bool Validate()
		{
			return false;
		}
	}

	public static class ToJavaScript
	{
		private static int callbackIdCounter;

		private static string prefix;

		public static void GetBrowserVersion()
		{
		}

		public static void ExternalCall(string functionName, params object[] args)
		{
		}

		public static void ExternalCall(string functionName, Action<bool, string> callback)
		{
		}

		private static string ToNameSpace(string functionName)
		{
			return null;
		}
	}

	private class Callback
	{
		private Action<bool, string> callbackFunction;

		public Callback(Action<bool, string> callbackFunction)
		{
		}

		public void Execute(bool success, string data)
		{
		}
	}

	public static bool enableExternalCall;

	public static bool enableBrowserRequest;

	private static string browserName;

	private static int browserVersion;

	private static Dictionary<int, Callback> callbacks;

	public Action<int, int> OnGoldPurchasedFromWeb;

	public static string BrowserName => null;

	public static int BrowserVersion => 0;

	public static void ExecuteBrowserRequest(string url)
	{
	}

	public void CreatePlanetScreenshot()
	{
	}

	public void PublishPlanetFromWeb()
	{
	}

	public void GiveBrowserInfo(string browserinfo)
	{
	}

	public void UserGoldUpdate(string data)
	{
	}

	public void ExternalCallback(string jsonData)
	{
	}

	public void Exit()
	{
	}
}
