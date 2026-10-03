using Assets.Scripts.AdIntegration;
using MV.Common;
using UnityEngine;
using UnityEngine.Events;

public class ReviveUIHandlerBoosts : ReviveUIHandlerBase
{
	[SerializeField]
	private GameObject defaultUI;

	[SerializeField]
	private GameObject tempClassUI;

	[SerializeField]
	private CurrentSpawnRolePreviewer spawnRolePreviewer;

	[SerializeField]
	private GameObject backgroundTier1;

	[SerializeField]
	private GameObject backgroundTier2;

	[SerializeField]
	private GameObject backgroundTier3;

	[SerializeField]
	private BoostImageController boostImageSelector;

	[SerializeField]
	private GameObject boostContent;

	private GamePassTier tier;

	protected override AdContext AdContext => AdContext.None;

	public override void Initialize(UnityAction onContinueClicked)
	{
	}

	private void ChangeBackground()
	{
	}

	protected override void OnAdFinishedContinue()
	{
	}

	private bool IsInTempClass()
	{
		return false;
	}

	private bool IsInTempTier()
	{
		return false;
	}

	protected override void Update()
	{
	}

	protected override void OnRewardedAdWatched(RewardedAdResult result)
	{
	}
}
