using System;
using Assets.Scripts.GamePasses;
using MV.Common;
using MV.WorldObject.GamePassSystem;

public static class GamePassesManager
{
	private static bool showGamePassDataInConsole;

	public static PlayerTierStateCalculator playerTierStateCalculator;

	public static Action OnPlayerPlanetDataUpdated;

	private static PlayerPlanetData playerPlanetData;

	private static TogglePreviewState togglePreviewState;

	public static bool ShowGamePassDataInConsole
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool GamePassesActive { get; set; }

	public static PlayerPlanetData PlayerPlanetData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static TogglePreviewState TogglePreviewState => null;

	public static void UpdatePlayerPlanetData(PlayerPlanetData playerPlanetData)
	{
	}

	private static void UpdateToggleState()
	{
	}

	public static void SendCompleteStatus()
	{
	}

	private static void HandleNewTierUnlocked(PlayerPlanetData newPlayerPlanetData)
	{
	}

	private static void SendTierUnlockedNotification(GamePassTier unlockedTier)
	{
	}
}
