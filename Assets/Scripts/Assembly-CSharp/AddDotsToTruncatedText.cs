using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AddDotsToTruncatedText : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddDotsToTruncatedText _003C_003E4__this;

		private Color _003Cc_003E5__2;

		private float _003Calpha_003E5__3;

		private string _003CtextValue_003E5__4;

		private bool _003CaddDots_003E5__5;

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
		public _003CStart_003Ed__1(int _003C_003E1__state)
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
	private Text text;

	[IteratorStateMachine(typeof(_003CStart_003Ed__1))]
	private IEnumerator Start()
	{
		return null;
	}

	private int CalculateLengthOfMessage(string message)
	{
		return 0;
	}
}
