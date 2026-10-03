using System;
using System.Collections.Generic;
using UnityEngine;

public class GameTierProgressBarGainEffectController : MonoBehaviour
{
	[Serializable]
	private class TierTargetData
	{
		public Transform gamePointEffectTargetTransform;

		public float tierScaleEffectStartTime;
	}

	[SerializeField]
	private Transform gamePointEffectContainer;

	[SerializeField]
	private GamePointGainEffect gamePointGainEffectPrefab;

	[SerializeField]
	private GameTierProgressBar tierProgressBar;

	[SerializeField]
	private float offsetDirectionXMin;

	[SerializeField]
	private float offsetDirectionXMax;

	[SerializeField]
	private float offsetDirectionYMin;

	[SerializeField]
	private float offsetDirectionYMax;

	[SerializeField]
	private List<TierTargetData> targetDataList;

	[SerializeField]
	private AnimationCurve onHitScaleEffect;

	private bool isInitialized;

	private int currentGamePoints;

	private int gamePointsToInstantiate;

	private float createGamePointTime;

	private const float createGamePointDelayMax = 0.2f;

	private const float createGamePointDelayMin = 0.1f;

	private const int maxAmountOfQueuedGainEffects = 10;

	private List<GamePointGainEffect> gamePointGainEffectPool;

	private List<GamePointGainEffect> gamePointGainEffectCurrentlyUsed;

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

	private void Update()
	{
	}

	private void HandleScaleEffect()
	{
	}

	private void OnPlayerPlanetDataUpdated()
	{
	}

	private void OnHaveShownGainEffect(int gamePointAmountShown)
	{
	}

	private void OnHaveShownTierProgressBarGainEffect(int gamePointAmountShown)
	{
	}

	private void HandleNewGamePointAmount(int newGamePointsAmount)
	{
	}

	private void StartGamePointGainEffect()
	{
	}

	private void CreateGamePointGainEffect()
	{
	}

	private void OnGamePointReached(int id)
	{
	}

	private Transform GetTargetTransform()
	{
		return null;
	}

	private void StopAllGainEffects()
	{
	}
}
