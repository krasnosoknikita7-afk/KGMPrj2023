using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sentry;
using UnityEngine;
using UnityEngine.Networking;

public class SentrySdk : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGetStackTraces_003Ed__20 : IEnumerable<StackTraceSpec>, IEnumerable, IEnumerator<StackTraceSpec>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private StackTraceSpec _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string stackTrace;

		public string _003C_003E3__stackTrace;

		private string[] _003CstackList_003E5__2;

		private int _003Ci_003E5__3;

		StackTraceSpec IEnumerator<StackTraceSpec>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetStackTraces_003Ed__20(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<StackTraceSpec> IEnumerable<StackTraceSpec>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CContinueSendingEvent_003Ed__23<T> : IEnumerator<UnityWebRequestAsyncOperation>, IEnumerator, IDisposable where T : SentryEvent
	{
		private int _003C_003E1__state;

		private UnityWebRequestAsyncOperation _003C_003E2__current;

		public SentrySdk _003C_003E4__this;

		public T @event;

		private UnityWebRequest _003Cwww_003E5__2;

		UnityWebRequestAsyncOperation IEnumerator<UnityWebRequestAsyncOperation>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CContinueSendingEvent_003Ed__23(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private float _timeLastError;

	private const float MinTime = 0.5f;

	private Breadcrumb[] _breadcrumbs;

	private int _lastBreadcrumbPos;

	private int _noBreadcrumbs;

	private Dsn _dsn;

	private bool _initialized;

	private bool sendDefaultPii;

	private bool Debug;

	private static SentrySdk _instance;

	public void Initialize(SentryConfig sentryConfig)
	{
	}

	public static void AddBreadcrumb(string message)
	{
	}

	public static void CaptureMessage(string message, Dictionary<string, object> extraSentryData, Dictionary<string, string> tags)
	{
	}

	public static void CaptureEvent(SentryEvent @event)
	{
	}

	private void DoCaptureMessage(string message, Dictionary<string, object> extraSentryData, Dictionary<string, string> tags)
	{
	}

	private void DoCaptureEvent(SentryEvent @event)
	{
	}

	private void DoAddBreadcrumb(string message)
	{
	}

	private List<Breadcrumb> GetBreadcrumbs()
	{
		return null;
	}

	public void ScheduleError(string condition, string stackTrace, Dictionary<string, object> extraSentryData, Dictionary<string, string> tags)
	{
	}

	public void ScheduleException(string condition, string stackTrace, Dictionary<string, object> extraSentryData, Dictionary<string, string> tags)
	{
	}

	[IteratorStateMachine(typeof(_003CGetStackTraces_003Ed__20))]
	private static IEnumerable<StackTraceSpec> GetStackTraces(string stackTrace)
	{
		return null;
	}

	public void OnLogMessageReceived(string condition, string stackTrace, LogType type, Dictionary<string, object> extraSentryData, Dictionary<string, string> tags)
	{
	}

	private void PrepareEvent(SentryEvent @event)
	{
	}

	[IteratorStateMachine(typeof(_003CContinueSendingEvent_003Ed__23<>))]
	private IEnumerator<UnityWebRequestAsyncOperation> ContinueSendingEvent<T>(T @event) where T : SentryEvent
	{
		return null;
	}
}
