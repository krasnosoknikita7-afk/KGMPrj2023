using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using UnityEngine;

public class PickupItemFlamethrower : PickupItem
{
	[CompilerGenerated]
	private sealed class _003CDoFlaming_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PickupItemFlamethrower _003C_003E4__this;

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
		public _003CDoFlaming_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CDoFuelBurn_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PickupItemFlamethrower _003C_003E4__this;

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
		public _003CDoFuelBurn_003Ed__17(int _003C_003E1__state)
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
	private ParticleSystem flameParticles;

	[SerializeField]
	private float hitRadius;

	[SerializeField]
	[Tooltip("How many seconds a fueltank lasts.")]
	private ObscuredFloat maxFuelTime;

	[SerializeField]
	private float maxRange;

	[SerializeField]
	private float flamerMinimumBurnTime;

	[SerializeField]
	private AudioSource audioSource;

	private float flamerStartTime;

	private bool isFlaming;

	private ObscuredFloat currentFuel;

	public override AvatarItemType Type => AvatarItemType.LaserPointer;

	public override int Quantity => 0;

	private bool IsStillFlaming()
	{
		return false;
	}

	private void Awake()
	{
	}

	public override void ResetAmmo()
	{
	}

	[IteratorStateMachine(typeof(_003CDoFlaming_003Ed__16))]
	private IEnumerator DoFlaming()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDoFuelBurn_003Ed__17))]
	private IEnumerator DoFuelBurn()
	{
		return null;
	}

	public override void TriggerBegin(int instigatorActorNr)
	{
	}

	public override void TriggerEnd()
	{
	}

	private void Update()
	{
	}
}
