using Assets.Scripts.AdIntegration;
using UnityEngine;
using UnityEngine.Events;

public class ReviveUIHandler : ReviveUIHandlerBase
{
	private const float minDistanceToCameraBeforeShowAvatar = 3f;

	private bool roundEndedWhileWatchingAd;

	private int currentSafePointSelected;

	private GameObject bodyClone;

	protected override AdContext AdContext => AdContext.None;

	public override void Initialize(UnityAction onContinueClicked)
	{
	}

	protected override void RoundEnded(IWinningCondition condition)
	{
	}

	private void OnGenerateTextureComplete(byte[] generatedTexture)
	{
	}

	protected override void Update()
	{
	}

	public override void OnWatchAdClicked()
	{
	}

	public override void OnSubscriberClicked()
	{
	}

	protected override void OnAdFinishedContinue()
	{
	}

	protected override void OnRewardedAdWatched(RewardedAdResult result)
	{
	}

	private void CreateAvatarBodyForScreenshot()
	{
	}

	private void CleanupAvatarBodyAfterScreenshot()
	{
	}
}
