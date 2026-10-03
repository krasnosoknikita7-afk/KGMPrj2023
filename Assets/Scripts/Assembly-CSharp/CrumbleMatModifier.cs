using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CrumbleMatModifier : AvatarModifier
{
	[CompilerGenerated]
	private sealed class _003CDoFadeAndDestroy_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrumbleMatModifier _003C_003E4__this;

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
		public _003CDoFadeAndDestroy_003Ed__9(int _003C_003E1__state)
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

	public ParticleSystem CrumbleParticles;

	private bool isDeactivating;

	public override AvatarModifierPackageType ModifierType => AvatarModifierPackageType.None;

	private void Awake()
	{
	}

	protected override void OnActivated(Avatar target)
	{
	}

	protected override void OnDeactivated(Avatar target)
	{
	}

	private void OnDisable()
	{
	}

	private void Destroy()
	{
	}

	[IteratorStateMachine(typeof(_003CDoFadeAndDestroy_003Ed__9))]
	private IEnumerator DoFadeAndDestroy()
	{
		return null;
	}

	private void Update()
	{
	}
}
