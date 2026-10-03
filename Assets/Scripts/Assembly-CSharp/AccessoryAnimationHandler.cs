using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AccessoryAnimationHandler : ActivateOnAnimationBase
{
	[Serializable]
	private struct AnimationData
	{
		public string animationName;

		public float animationSpeed;

		public string TransitionToAnimationName;
	}

	[CompilerGenerated]
	private sealed class _003CTransitionToNewAnimation_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccessoryAnimationHandler _003C_003E4__this;

		public float resetDelay;

		public string transitionToAnimationName;

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
		public _003CTransitionToNewAnimation_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CStopAnimationNextFrame_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccessoryAnimationHandler _003C_003E4__this;

		private bool _003ChasFramePassed_003E5__2;

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
		public _003CStopAnimationNextFrame_003Ed__19(int _003C_003E1__state)
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
	private Animation animations;

	[SerializeField]
	private List<AnimationData> animationData;

	private string currentCrossFadedAnimation;

	private bool shouldTransitionToNewAnimation;

	private const float crossfadeDuration = 0.2f;

	protected override void Start()
	{
	}

	public override void OnAvatarAnimationChange(string newAnimation)
	{
	}

	private Avatar GetAvatar()
	{
		return null;
	}

	private bool HaveAnimationData(string animationName)
	{
		return false;
	}

	public void PlayAnimation(string animationName)
	{
	}

	private void ApplyAnimationSpeed(string animationName)
	{
	}

	public float GetAnimationSpeed(string animationName)
	{
		return 0f;
	}

	public void Initialize()
	{
	}

	public void SetAllAnimationToLooping()
	{
	}

	[IteratorStateMachine(typeof(_003CTransitionToNewAnimation_003Ed__15))]
	private IEnumerator TransitionToNewAnimation(float resetDelay, string transitionToAnimationName)
	{
		return null;
	}

	private void StartTransitioning(string transitionToAnimationName)
	{
	}

	private void StartCrossfading(string animationName)
	{
	}

	private void HandleNoIdleAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CStopAnimationNextFrame_003Ed__19))]
	private IEnumerator StopAnimationNextFrame()
	{
		return null;
	}
}
