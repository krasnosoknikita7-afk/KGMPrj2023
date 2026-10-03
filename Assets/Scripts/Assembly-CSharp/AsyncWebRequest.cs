using System;
using UnityEngine.Networking;

public abstract class AsyncWebRequest
{
	protected enum State
	{
		Created = 0,
		Running = 1,
		Waiting = 2
	}

	protected Action<UnityWebRequest> callback;

	protected readonly string path;

	protected int retries;

	protected TimeSpan currentTimeout;

	protected DateTime retryTime;

	protected State state;

	protected UnityWebRequest request;

	protected bool isDone;

	public readonly WWWRequestPriority requestPriority;

	protected static bool CacheCompatibility => false;

	public Action<UnityWebRequest> Callback
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static bool CheckCacheCompatibility()
	{
		return false;
	}

	protected AsyncWebRequest(string path, Action<UnityWebRequest> callback, WWWRequestPriority requestPriority)
	{
	}

	public bool Update()
	{
		return false;
	}

	public void Dispose()
	{
	}

	private void GotoRunState()
	{
	}

	protected virtual bool UpdateRunningState()
	{
		return false;
	}

	protected bool ReadyToDoCallback()
	{
		return false;
	}

	private bool IsWaitingStateDone()
	{
		return false;
	}

	protected abstract UnityWebRequest Create();

	public override string ToString()
	{
		return null;
	}
}
