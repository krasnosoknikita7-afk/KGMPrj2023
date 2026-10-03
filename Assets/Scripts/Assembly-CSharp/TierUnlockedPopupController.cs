using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class TierUnlockedPopupController : MonoBehaviour
{
	[SerializeField]
	private Image Background;

	[SerializeField]
	private TierUnlockedPopupContentTierUnlocked PopupContentTierUnlockedPrefab;

	[SerializeField]
	private TierUnlockedPopupContentXP PopupContentXPPrefab;

	[SerializeField]
	private TierUnlockedPopupContentSpawnRole popupContentSpawnRolePrefab;

	[SerializeField]
	private GamePassesSpawnRoleRewardInfo spawnRoleInfoPrefab;

	[SerializeField]
	private TierUnlockedPopupContentBase PopupContentCreatorSupportPrefab;

	[SerializeField]
	private TierTempUnlockedInformationPopupContent popupContentTempUnlockInformationPrefab;

	[SerializeField]
	private TierUnlockedPopupContentTierTempUnlocked popupContentTierTempUnlockPrefab;

	[SerializeField]
	private float fadeDuration;

	[SerializeField]
	private float bounceEffectDuration;

	[SerializeField]
	private float colorInterpolationDuration;

	[SerializeField]
	private AnimationCurve bounceEffect;

	[SerializeField]
	private AnimationCurve fadeEffect;

	private List<TierUnlockedPopupContentBase> popupContentList;

	private int currentContentBeingShowed;

	private GamePassTier unlockedTier;

	private bool isPoppingCountdownStarted;

	private float popTime;

	private Color interpolateToColor;

	private float interpolateColorStartTime;

	private float bounceEffectStartTime;

	private float fadeEffectStartTime;

	public static GamePassTier HighestTierRewardShown;

	public void Initialize(GamePassTier unlockedTier, bool wasPurchased, bool wasTempUnlocked)
	{
	}

	private void Update()
	{
	}

	private void OnStartingToDissappear()
	{
	}

	private void StartNewPopupContent(int index)
	{
	}
}
