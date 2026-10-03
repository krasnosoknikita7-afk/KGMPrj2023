using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class SizeModifier : AvatarModifier
{
	protected delegate void ActionDelegate(float time);

	[CompilerGenerated]
	private sealed class _003CDoForSeconds_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SizeModifier _003C_003E4__this;

		public ActionDelegate body;

		public float duration;

		private float _003Ct_003E5__2;

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
		public _003CDoForSeconds_003Ed__17(int _003C_003E1__state)
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
	protected float timeToSize;

	[SerializeField]
	protected float sizeModifier;

	[SerializeField]
	protected float sizeUnstableAfterSeconds;

	[SerializeField]
	protected float unstableSpeed;

	[SerializeField]
	protected float sineStrength;

	[SerializeField]
	protected AudioSource audioSource;

	protected Vector3 defaultScale;

	protected bool isDeactivating;

	public AudioClip growSound;

	public AudioClip shrinkSound;

	protected override void OnActivated(Avatar target)
	{
	}

	public override void ResetTimeStamp()
	{
	}

	protected override void OnDeactivated(Avatar target)
	{
	}

	protected virtual void UnScale()
	{
	}

	protected virtual void Scale()
	{
	}

	protected float BlockStep(float t, float steps, float clampMin, float clampMax)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CDoForSeconds_003Ed__17))]
	protected IEnumerator DoForSeconds(float duration, ActionDelegate body)
	{
		return null;
	}

	protected void Unstablize()
	{
	}
}
