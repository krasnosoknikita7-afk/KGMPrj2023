using System;
using MV.WorldObject;
using UnityEngine;

public class TierBoostStateHandler : MonoBehaviour
{
	[SerializeField]
	private TeamMenu teamMenuPrefab;

	[SerializeField]
	private SpawnRoleMenu spawnRoleSelectionMenuPrefab;

	private Action<bool> onFinished;

	public void StopPreviewTier(Action<bool> onFinishPreviewTier)
	{
	}

	private void OnPlayerPlanetDataUpdated()
	{
	}

	private void ExitContinuePopup()
	{
	}

	private void ShowSpawnRoleSelectionMenu()
	{
	}

	private void ShowTeamSelectionMenu()
	{
	}

	private bool IsInTempClass()
	{
		return false;
	}

	public bool IsInTempTier()
	{
		return false;
	}

	private bool CanSpawnInTeam(MVTeam team)
	{
		return false;
	}
}
