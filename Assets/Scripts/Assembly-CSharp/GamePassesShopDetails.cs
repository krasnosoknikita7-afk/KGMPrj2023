using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class GamePassesShopDetails : MonoBehaviour
{
	[SerializeField]
	private GamePassesShop gamePassesShopPrefab;

	[SerializeField]
	private GamePassesHighScoreList highScoreListPrefab;

	[SerializeField]
	private List<CanvasGroup> tierOutlineList;

	private float interpolationStartTime;

	private GamePassTier currentFocusedTier;

	private const float outlineInterpolationSpeed = 2f;

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void ResetHighlightEffects()
	{
	}

	private void InstantiateGamePassesShop(GamePassTier tierToShow)
	{
	}

	public void Exit()
	{
	}

	public void OnTierDetailEnter(GamePassTier tierEntered)
	{
	}

	public void OnTierDetailExit(GamePassTier tierExited)
	{
	}

	public void OnTier1ShopPressed()
	{
	}

	public void OnTier2ShopPressed()
	{
	}

	public void OnTier3ShopPressed()
	{
	}

	public void ShowHighScore()
	{
	}
}
