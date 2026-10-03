using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class GamePassesHighlightArrowManager : MonoBehaviour
{
	[SerializeField]
	private GameObject highlightArrowPrefab;

	[SerializeField]
	private List<Transform> progressBarTransfromsList;

	private GameObject highLightArrow;

	private GamePassTier currentGamePassTierHighlighted;

	private static bool isHighlightingTierUnlocked;

	private static bool shouldDestroyHighlighArrow;

	public void OnTierBeingShown(GamePassTier tierBeingShown)
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnPlayerPlanetDataUpdated()
	{
	}

	private void HandleUnseenTierUnlockReward()
	{
	}

	private void DestroyHighlighArrow()
	{
	}

	private void CreateHighlightArrow(GamePassTier gamePassTierToHighlight)
	{
	}
}
