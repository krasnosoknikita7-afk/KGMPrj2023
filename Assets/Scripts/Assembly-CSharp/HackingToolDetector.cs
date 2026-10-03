using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MV.WorldObject.AntiCheat;
using UnityEngine;

public class HackingToolDetector : MonoBehaviour
{
	public enum ReportCategory
	{
		process = 0,
		regKey = 1,
		unknown = 2,
		SIZE = 3
	}

	public class HackingToolReport
	{
		public enum Kind
		{
			process = 0,
			suspectProcess = 1,
			regKey = 2,
			suspectKey = 3,
			debugLog = 4
		}

		public Kind kind;

		public ApplicationDesc app;

		public ApplicationDesc.RegistryKey foundKey;

		public string exactFind;

		public HackingToolReport(ApplicationDesc app)
		{
		}

		public HackingToolReport(ApplicationDesc app, string exactFind)
		{
		}

		public HackingToolReport(ApplicationDesc app, ApplicationDesc.RegistryKey foundKey)
		{
		}

		public HackingToolReport(ApplicationDesc app, ApplicationDesc.RegistryKey foundKey, string exactFind)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CScan_Coroutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HackingToolDetector _003C_003E4__this;

		private float _003CwaitDuration_003E5__2;

		object IEnumerator<object>.Current
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
		public _003CScan_Coroutine_003Ed__28(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CHandleReports_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HackingToolDetector _003C_003E4__this;

		private float _003CwaitDuration_003E5__2;

		object IEnumerator<object>.Current
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
		public _003CHandleReports_003Ed__30(int _003C_003E1__state)
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

	[SerializeField]
	private HackingToolDetectorSO sharedProperties;

	public static readonly string CheatWarning;

	public Action<HackingToolReport> onHackToolDetected;

	private BitArray alreadyReported;

	private ApplicationDesc[] banList;

	private static HackingToolDetector instance;

	private bool _quitRequest;

	private object _quitLock;

	public ThreadSafeQueue<HackingToolReport> detectedHackingTools;

	public static bool InstallTracesDetected => false;

	public static bool ProcessDetected => false;

	private static HackingToolDetector Instance => null;

	private static float WaitTime => 0f;

	private bool QuitRequest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private static void DebugLogToChat(string str)
	{
	}

	public void TemporaryReportHandler(HackingToolReport a)
	{
	}

	public void InjectionDetectedCallback(string msg)
	{
	}

	protected void Start()
	{
	}

	public static void Initialize(ApplicationDesc[] banList)
	{
	}

	private void InitiateDetection()
	{
	}

	protected void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CScan_Coroutine_003Ed__28))]
	private IEnumerator Scan_Coroutine()
	{
		return null;
	}

	private static void ScanForForbiddenProcesses()
	{
	}

	[IteratorStateMachine(typeof(_003CHandleReports_003Ed__30))]
	private IEnumerator HandleReports()
	{
		return null;
	}

	public static void Report(HackingToolReport report)
	{
	}
}
