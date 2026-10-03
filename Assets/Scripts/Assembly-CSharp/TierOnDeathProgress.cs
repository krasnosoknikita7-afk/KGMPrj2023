using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MV.Common;
using MV.WorldObject.GamePassSystem;
using UnityEngine;
using UnityEngine.UI;

public class TierOnDeathProgress : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoTierProgress_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TierOnDeathProgress _003C_003E4__this;

		private Dictionary<GamePassTier, PlayerTierState> _003CgameTierShopStatus_003E5__2;

		private int _003Cto_003E5__3;

		private int _003Ccurrent_003E5__4;

		private bool _003Cstopped_003E5__5;

		private float _003CtotalProgress_003E5__6;

		private float _003ClockLerpTimer_003E5__7;

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
		public _003CDoTierProgress_003Ed__32(int _003C_003E1__state)
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
	private Text crystalsGainedSinceDeath;

	[SerializeField]
	private Text nextTierText;

	[SerializeField]
	private ProgressBar tierProgressBar;

	[SerializeField]
	private Text progressText;

	[SerializeField]
	private GameObject progressBarDivider;

	[SerializeField]
	private float progressLerpDuration;

	[SerializeField]
	private float lockFadeLerpDuration;

	[SerializeField]
	private AnimationCurve lockShakeCurve;

	[SerializeField]
	private RectTransform lockImage;

	[SerializeField]
	private CanvasGroup unlockImage;

	private GamePassTier currentTier;

	private int crystalValue;

	private float currentCrystalValue;

	private float timer;

	private float crystalTimer;

	private float timeBeforeStartLerp;

	private float fromProgress;

	private float toProgress;

	private int currentGamePoints;

	private int gamePointsRequired;

	private Vector3 lockStartRot;

	private float intensity;

	private float tierToInterpolateFrom;

	private float tierToInterpolateTo;

	private bool unlockingTier;

	public bool IsShowingTierProgress { get; private set; }

	public void Initialize()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CDoTierProgress_003Ed__32))]
	private IEnumerator DoTierProgress()
	{
		return null;
	}

	private void Update()
	{
	}

	private float CalculateTotalProgressValue(int gamePoints)
	{
		return 0f;
	}

	private int ReduceGamePointsWithPreviousTierRequirements(GamePassTier gamePassTierToDisplay, int gamePoints, Dictionary<GamePassTier, PlayerTierState> gameTierShopStatus)
	{
		return 0;
	}
}
