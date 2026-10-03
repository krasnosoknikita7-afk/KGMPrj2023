using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameMeterVisuals;
using MV.Common;
using MV.WorldObject.GamePassSystem;
using UnityEngine;
using UnityEngine.UI;

public class GameTierProgressBar : MonoBehaviour, HoverInputReceiver
{
	[Serializable]
	private struct TierProgressData
	{
		public ProgressBar progressBar;

		public Text progressText;

		public GameObject progressDivider;

		public GamePassesTextBubble progressBarTextBubble;

		public GamePassesTextBubble avatarHead;

		public RawImage avatarHeadImage;

		public GameObject avatarHeadUI;

		public ProgressBar disabledProgressBar;

		public GameObject disabledProgressDivider;

		public GamePassesTextBubble disabledBarTextBubble;

		public GameObject tierIconTempUnlock;

		public GameObject tierIconNumber;

		public ProgressBar endResultProgressBar;

		public GameObject tempProgress;

		public GameObject disabledTempProgress;

		public GamePassesTextBubble freeTryTextBubble;

		public HoverInputHandler hoverInputHandler;

		public CanvasGroup LockedTierIcon;
	}

	[CompilerGenerated]
	private sealed class _003CScaleAndFadeLockForTier_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameTierProgressBar _003C_003E4__this;

		public int tier;

		private float _003Cprogress_003E5__2;

		private float _003Calpha_003E5__3;

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
		public _003CScaleAndFadeLockForTier_003Ed__43(int _003C_003E1__state)
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
	private AvatarPreviewer previewer;

	[SerializeField]
	private GamePassesTextBubble highScoreTipTextBubble;

	[SerializeField]
	private GameObject betaModeInformationPopup;

	[SerializeField]
	private GameObject buildModeInformationPopup;

	[SerializeField]
	private GameObject touristInformationPopup;

	[SerializeField]
	private float unlockedTierLerpDuration;

	[SerializeField]
	protected List<GameMeterVisualEffect> gameMeterVisualEffects;

	[SerializeField]
	private List<TierProgressData> tierProgressDataList;

	private const float interpolationDuration = 2f;

	private const int avatarHeadImageWidth = 128;

	private const int avatarHeadImageHeight = 128;

	private static bool haveShownTips;

	private bool isInitialized;

	private bool shouldInterpolate;

	private bool hasShownRankTip;

	private float interpolateTowardsProgressValue;

	private float previousProgressValue;

	private float interpolationStartTime;

	private AvatarPreviewer headPreviewer;

	private Transform previewHeadRoot;

	public void OnHeadClick()
	{
	}

	public void OnInactiveProgressBarClicked(int progressBarNumberPressed)
	{
	}

	public void OnActiveProgressBarClicked(int progressBarNumberPressed)
	{
	}

	public void OnHoverEnter()
	{
	}

	public void OnHoverExit()
	{
	}

	public GamePassTier GetCurrentTier()
	{
		return GamePassTier.Tier0;
	}

	public void DeactivateFreeTryBubble()
	{
	}

	public void Initialize()
	{
	}

	public void ReplayGainEffect(int previousGamePointAmount, int newGamePointAmount)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void DestroyHeadPreview()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void OnPlayerPlanetDataUpdated()
	{
	}

	private void OnHaveShownGainEffect(int newGamePointAmountShown)
	{
	}

	private void OnHaveShownTierProgressBarGainEffect(int newGamePointAmountShown)
	{
	}

	private void UpdateProgressBars(int playerGamePoints)
	{
	}

	private void HandleUnlockedTiersProgressBars()
	{
	}

	private void UpdateEditModeDisabledProgressBars()
	{
	}

	private void UpdateProgressBar(GamePassTier progressBarToUpdate, int playerGamePoints)
	{
	}

	[IteratorStateMachine(typeof(_003CScaleAndFadeLockForTier_003Ed__43))]
	private IEnumerator ScaleAndFadeLockForTier(int tier)
	{
		return null;
	}

	private void SetLockedStateForTier(int tier, bool tierUnlocked)
	{
	}

	private void ActivateBar(int barIndex)
	{
	}

	private void DeactivateBar(int barIndex)
	{
	}

	private float GetProgressBarPercentage(GamePassTier tierToShowProgressFor)
	{
		return 0f;
	}

	private int ReduceGamePointsWithPreviousTierRequirements(GamePassTier gamePassTierToDisplay, int gamePoints, Dictionary<GamePassTier, PlayerTierState> gameTierShopStatus)
	{
		return 0;
	}

	private void UpdateDividerVisibility(int playerGamePoints)
	{
	}

	private void UpdateTempProgressVisibility()
	{
	}

	private bool HasTempTier(GamePassTier tier)
	{
		return false;
	}

	private bool HasAnyTempTier()
	{
		return false;
	}

	private void UpdateTierIconHoverInput()
	{
	}

	private bool ShowFreeTryTextBubble()
	{
		return false;
	}

	private bool CanShowFreeTryBubble()
	{
		return false;
	}

	private float CalculateTotalProgressValue(int gamePoints)
	{
		return 0f;
	}

	private int CalculateGamePointsFromTotalProgress(float totalProgressValue)
	{
		return 0;
	}

	private int CalculateGamePointsFromTierProgress(float totalProgressValue, GamePassTier tierToCalculateTo)
	{
		return 0;
	}

	private void UpdateProgressText(float totalProgress, GamePassTier currentTier)
	{
	}

	private void HandleDisabledProgressBarVisibility()
	{
	}

	private void HandleFreeTryVisibility()
	{
	}

	private void HandleShowTips()
	{
	}

	private bool IsProgressBarEnabled()
	{
		return false;
	}

	private bool IsTierUnlocked(GamePassTier tierToCheck)
	{
		return false;
	}

	private void CreateAvatarHeadImages()
	{
	}
}
