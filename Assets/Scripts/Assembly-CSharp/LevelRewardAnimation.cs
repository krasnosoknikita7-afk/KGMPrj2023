using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LevelRewardAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisplayAndFadePrevBadge_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelRewardAnimation _003C_003E4__this;

		private float _003CcurrentTime_003E5__2;

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
		public _003CDisplayAndFadePrevBadge_003Ed__28(int _003C_003E1__state)
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
	private sealed class _003CDisplayAndFadeNextBadge_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelRewardAnimation _003C_003E4__this;

		private float _003CcurrentTime_003E5__2;

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
		public _003CDisplayAndFadeNextBadge_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CDisplayAndFadeGoldIcon_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelRewardAnimation _003C_003E4__this;

		private float _003CcurrentTime_003E5__2;

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
		public _003CDisplayAndFadeGoldIcon_003Ed__30(int _003C_003E1__state)
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
	private RawImage prevLevelBadge;

	[SerializeField]
	private float prevLevelDisplayTime;

	[SerializeField]
	private AnimationCurve prevBadgeBounceEffect;

	[SerializeField]
	private RawImage nextLevelBadge;

	[SerializeField]
	private float nextLevelDisplayTime;

	[SerializeField]
	private AnimationCurve nextBadgeBounceEffect;

	[SerializeField]
	private Image goldImage;

	[SerializeField]
	private float goldImageDisplayTime;

	[SerializeField]
	private AnimationCurve goldBounceEffect;

	[SerializeField]
	private AnimationCurve goldFadeInCurve;

	[SerializeField]
	private AnimationCurve rotateUIYAxisIn;

	[SerializeField]
	private AnimationCurve rotateUIYAxisOut;

	[SerializeField]
	private float rotateUIYAxisTime;

	[SerializeField]
	private Text header;

	[SerializeField]
	private Text goldText;

	[SerializeField]
	private CanvasGroup claimButton;

	[SerializeField]
	private AnimationCurve backgroundRaySizeCurve;

	[SerializeField]
	private Image backgroundRays;

	[SerializeField]
	private int targetSize;

	private List<KeyValuePair<int, int>> rewards;

	private KeyValuePair<int, int> currentReward;

	private Texture2D previousBadgeTextureAsset;

	private Texture2D currentBadgeTextureAsset;

	public void Initialize(Dictionary<int, int> levelRewards)
	{
	}

	public void OnShow()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnPrevBadgeLoaded(UnityWebRequest www)
	{
	}

	private void OnNextBadgeLoaded(UnityWebRequest www)
	{
	}

	[IteratorStateMachine(typeof(_003CDisplayAndFadePrevBadge_003Ed__28))]
	private IEnumerator DisplayAndFadePrevBadge()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDisplayAndFadeNextBadge_003Ed__29))]
	private IEnumerator DisplayAndFadeNextBadge()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDisplayAndFadeGoldIcon_003Ed__30))]
	private IEnumerator DisplayAndFadeGoldIcon()
	{
		return null;
	}
}
