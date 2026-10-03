using System;
using System.Collections.Generic;
using UnityEngine.Networking;

public static class AsyncWWWManager
{
	public class Cache
	{
		private Dictionary<string, CachedGetRequest> cachedRequests;

		public bool TryGet(string path, out CachedGetRequest cachedGetRequest)
		{
			cachedGetRequest = null;
			return false;
		}

		public void Add(string path, CachedGetRequest cachedGetRequest)
		{
		}

		public void UnsubscribeCached(Action<UnityWebRequest> callback)
		{
		}

		public void Clear()
		{
		}
	}

	private class TemporaryHashSet<T> : HashSet<T>, IDisposable
	{
		public void Dispose()
		{
		}
	}

	private const int quitTimeOut = 5000;

	private const int maxRequests = 4;

	private static readonly HashSet<AsyncWebRequest> activeRequests;

	private static readonly TemporaryHashSet<AsyncWebRequest> tempHashSet;

	private static int retries;

	public static readonly int[] RetryTimeouts;

	private static Action quitCallback;

	private static int quitTime;

	private static bool isQuiting;

	private static readonly Dictionary<WWWRequestPriority, Queue<AsyncWebRequest>> requests;

	private static Cache cache;

	public static int Retries => 0;

	public static void WWWRequest(AsyncWebRequest asyncRequest)
	{
	}

	public static void ShutDown(Action quitHandled)
	{
	}

	public static void UnsubscribeWWWRequest(Action<UnityWebRequest> callback)
	{
	}

	public static void BackgroundUpdate()
	{
	}

	public static void Update()
	{
	}

	public static void Reset()
	{
	}

	public static void PostResetCleanup()
	{
	}

	private static void Unsubscribe(AsyncWebRequest request, Action<UnityWebRequest> callback)
	{
	}

	private static void AddRequestsToActiveRequests(Queue<AsyncWebRequest> requestQueue, int maxRequestForQueue)
	{
	}

	private static void Quit()
	{
	}
}
