using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShieldedModifier : AvatarModifier
{
	[CompilerGenerated]
	private sealed class _003CMakeVisible_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShieldedModifier _003C_003E4__this;

		public float fadeInTime;

		public float fadeOutTime;

		private float _003CcurrRim_003E5__2;

		private Color _003CcurrColor_003E5__3;

		private float _003Ci_003E5__4;

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
		public _003CMakeVisible_003Ed__14(int _003C_003E1__state)
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
	private MeshRenderer shieldRenderer;

	[SerializeField]
	private float targetRimVisibility;

	[SerializeField]
	private float targetAlpha;

	[SerializeField]
	private RotatingShieldLine lineRenderer;

	private Material shieldMat;

	private bool readyToPlayEffect;

	private float prevHealth;

	public override AvatarModifierPackageType ModifierType => AvatarModifierPackageType.None;

	public override bool EvaluateShouldBeAdded(Dictionary<AvatarModifierPackageType, AvatarModifier> modifiers)
	{
		return false;
	}

	protected override void OnActivated(Avatar target)
	{
	}

	protected override void OnDeactivated(Avatar target)
	{
	}

	private void AvatarStateChangedHandler(object state)
	{
	}

	private void OnHealthChange(object floatHealth)
	{
	}

	[IteratorStateMachine(typeof(_003CMakeVisible_003Ed__14))]
	private IEnumerator MakeVisible(float fadeInTime, float fadeOutTime)
	{
		return null;
	}
}
