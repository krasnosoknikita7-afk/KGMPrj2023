using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameMeterVisuals;
using UnityEngine;

public class HealthbarLerp : GameMeterVisualEffect
{
	[CompilerGenerated]
	private sealed class _003CLerpProgress_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealthbarLerp _003C_003E4__this;

		private float _003Cprogress_003E5__2;

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
		public _003CLerpProgress_003Ed__10(int _003C_003E1__state)
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

	private float lerpForSeconds;

	private float lerpDelay;

	private float lerpStart;

	private float startProgress;

	private bool isInitialized;

	[SerializeField]
	private ProgressBar progressBar;

	[SerializeField]
	private ProgressBar targetProgressBar;

	private void OnEnable()
	{
	}

	public override void ExecuteEffect()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CLerpProgress_003Ed__10))]
	private IEnumerator LerpProgress()
	{
		return null;
	}
}
