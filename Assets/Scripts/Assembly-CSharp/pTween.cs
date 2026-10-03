using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class pTween
{
	[CompilerGenerated]
	private sealed class _003CTo_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public Action<float> callback;

		public float startValue;

		public float endValue;

		private float _003Cend_003E5__2;

		private float _003CdurationInv_003E5__3;

		private float _003CstartMulDurationInv_003E5__4;

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
		public _003CTo_003Ed__0(int _003C_003E1__state)
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
	private sealed class _003CRealtimeTo_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public Action<float> callback;

		public float startValue;

		public float endValue;

		private float _003Cend_003E5__2;

		private float _003CdurationInv_003E5__3;

		private float _003CstartMulDurationInv_003E5__4;

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
		public _003CRealtimeTo_003Ed__1(int _003C_003E1__state)
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

	[IteratorStateMachine(typeof(_003CTo_003Ed__0))]
	public static IEnumerator To(float duration, float startValue, float endValue, Action<float> callback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRealtimeTo_003Ed__1))]
	public static IEnumerator RealtimeTo(float duration, float startValue, float endValue, Action<float> callback)
	{
		return null;
	}

	public static IEnumerator To(float duration, Action<float> callback)
	{
		return null;
	}

	public static void WorkerTo(float duration, float startValue, float endValue, Action<float> callback)
	{
	}

	public static void WorkerTo(float duration, Action<float> callback)
	{
	}
}
