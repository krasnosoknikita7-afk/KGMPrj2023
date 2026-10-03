using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Worker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoTo_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Worker _003C_003E4__this;

		public float duration;

		public float startValue;

		public float endValue;

		public Action<float> callback;

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
		public _003CDoTo_003Ed__1(int _003C_003E1__state)
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

	public void To(float duration, float startValue, float endValue, Action<float> callback)
	{
	}

	[IteratorStateMachine(typeof(_003CDoTo_003Ed__1))]
	public IEnumerator DoTo(float duration, float startValue, float endValue, Action<float> callback)
	{
		return null;
	}
}
