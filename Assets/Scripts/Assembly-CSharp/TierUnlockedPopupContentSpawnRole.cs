using MV.Common;
using UnityEngine;
using UnityEngine.Events;

public class TierUnlockedPopupContentSpawnRole : TierUnlockedPopupContentBase
{
	[SerializeField]
	private GamePassesShopContentCuller contentCuller;

	public override void Initialize(GamePassTier unlockedGamePassTier, UnityAction onDisplayDoneCallback)
	{
	}

	protected override void HandleDisplaying()
	{
	}

	public void AddSpawnRoleRewardInfo(GamePassesSpawnRoleRewardInfo spawnRoleInfo)
	{
	}

	public void OnContinuePressed()
	{
	}
}
