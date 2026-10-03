using Assets.Scripts.AdIntegration;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class ReviveUIHandlerBase : MonoBehaviour
{
	[SerializeField]
	protected Button continueButton;

	[SerializeField]
	protected Button declineButton;

	[SerializeField]
	private Image timerFill;

	[SerializeField]
	private Text timerText;

	[SerializeField]
	protected ContinueButtonLockCursor continuePopup;

	[SerializeField]
	protected RawImage targetTexture;

	[SerializeField]
	protected NotificationPopup errorNotification;

	[SerializeField]
	protected GameObject icon;

	[SerializeField]
	protected GameObject countdown;

	[SerializeField]
	protected GameObject reviveButton;

	protected bool isSubscriber;

	private bool watchAdClicked;

	private float started;

	private float duration;

	protected abstract AdContext AdContext { get; }

	protected abstract void OnRewardedAdWatched(RewardedAdResult result);

	protected abstract void OnAdFinishedContinue();

	public virtual void Initialize(UnityAction onContinueClicked)
	{
	}

	private void ReviveTimeElapsed()
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void RoundEnded(IWinningCondition condition)
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void OnWatchAdClicked()
	{
	}

	public virtual void OnSubscriberClicked()
	{
	}
}
