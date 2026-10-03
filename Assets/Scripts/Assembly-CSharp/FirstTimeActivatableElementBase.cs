using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MV.Common;
using MV.WorldObject.MetaData;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class FirstTimeActivatableElementBase : FirstTimeEventHandler, IActivatableFirstTimeUiElement, IFirstTimeEventSkip, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CShowDelay_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FirstTimeActivatableElementBase _003C_003E4__this;

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
		public _003CShowDelay_003Ed__26(int _003C_003E1__state)
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

	protected bool isRegistered;

	[SerializeField]
	private SoundStyle onShowSound;

	[SerializeField]
	private FirstTimeEvent prerequisiteEvent;

	[SerializeField]
	private int priority;

	[SerializeField]
	private MVGameMode eventAllowedForMode;

	[SerializeField]
	private bool eventAllowedInAnyMode;

	[SerializeField]
	protected float delayBeforeShown;

	[SerializeField]
	[Tooltip("Set false to avoid checking for blocking elements in the stack.")]
	private bool checkForStackBlocking;

	private bool waitingForDelay;

	public FirstTimeEvent FirstTimeEvent => FirstTimeEvent.SkipEvent;

	public FirstTimeEvent PrerequisiteEvent => FirstTimeEvent.SkipEvent;

	public int Priority => 0;

	public bool IsRegistered => false;

	protected bool IsEventAllowedInMode => false;

	public abstract bool CanShow { get; }

	public bool IsShowing { get; private set; }

	protected bool IsBlocked => false;

	public void Show()
	{
	}

	[IteratorStateMachine(typeof(_003CShowDelay_003Ed__26))]
	private IEnumerator ShowDelay()
	{
		return null;
	}

	private void DoShow()
	{
	}

	public virtual void OnShow()
	{
	}

	public virtual void OnActivate()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnFirstTimeState(FirstTimeState firstTimeState, FirstTimeEvent latestFirstTimeEvent)
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected void UnRegister()
	{
	}

	public void SkipEvent()
	{
	}
}
