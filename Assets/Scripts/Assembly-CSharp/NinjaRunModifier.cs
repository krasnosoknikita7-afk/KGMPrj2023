using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NinjaRunModifier : AvatarModifier
{
	[CompilerGenerated]
	private sealed class _003CDoFadeAndDestroy_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NinjaRunModifier _003C_003E4__this;

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
		public _003CDoFadeAndDestroy_003Ed__17(int _003C_003E1__state)
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

	public TrailRenderer trailRenderer;

	[SerializeField]
	private float startWidth;

	[SerializeField]
	private float endWidth;

	[SerializeField]
	private float trailHeight;

	[SerializeField]
	private AudioSource soundEffect;

	private Vector3 oldPosition;

	private Vector3 oldScale;

	private float initialVolume;

	private bool isDestroying;

	private Transform ownerTransform;

	private const float minRemoteSpeed = 0.1f;

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

	[IteratorStateMachine(typeof(_003CDoFadeAndDestroy_003Ed__17))]
	private IEnumerator DoFadeAndDestroy()
	{
		return null;
	}

	private void Update()
	{
	}
}
