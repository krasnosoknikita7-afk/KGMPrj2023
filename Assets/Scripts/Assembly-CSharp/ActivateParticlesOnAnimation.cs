using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActivateParticlesOnAnimation : ActivateOnAnimationBase
{
	[Serializable]
	private struct ActivationData
	{
		public string activatingAnimation;

		public float activationDelay;
	}

	[CompilerGenerated]
	private sealed class _003CPlayParticles_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float activationDelay;

		public ActivateParticlesOnAnimation _003C_003E4__this;

		private float _003CstartTime_003E5__2;

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
		public _003CPlayParticles_003Ed__4(int _003C_003E1__state)
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
	private ParticleSystem particles;

	[SerializeField]
	private List<ActivationData> activationDataList;

	public override void OnAvatarAnimationChange(string newAnimation)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayParticles_003Ed__4))]
	private IEnumerator PlayParticles(float activationDelay)
	{
		return null;
	}
}
