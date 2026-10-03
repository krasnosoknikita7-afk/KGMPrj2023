using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubscriberJoinedNotification : Notification
{
	private enum subscriberJoinedStateType : byte
	{
		NotInitializedState = 0,
		WaitBeforeStartState = 1,
		StartState = 2,
		HighlightState = 3,
		ClosingDownState = 4,
		EndState = 5
	}

	[SerializeField]
	private Text userNameText;

	[SerializeField]
	private Text boostAmountText;

	[SerializeField]
	private RectTransform backGround;

	[SerializeField]
	private CanvasGroup backgroundCanvasGroup;

	[SerializeField]
	private GameObject content;

	[SerializeField]
	private AnimationCurve updateBoostTextEffectCurve;

	[SerializeField]
	private AnimationCurve fadeOutCurve;

	[SerializeField]
	private AnimationCurve closeShrinkYEffectCurve;

	[SerializeField]
	private AnimationCurve closeShrinkXEffectCurve;

	private const float waitBeforeStartDuration = 1f;

	private const float startDuration = 1.5f;

	private const float memberHighlightDuration = 2f;

	private const float closeDuration = 0.5f;

	private const float boostEffectOnStartDelay = 0.208334f;

	private float stateStartTime;

	private subscriberJoinedStateType currentState;

	private float backgroundOriginalWidth;

	private float backgroundOriginalHeigt;

	private Vector2 backgroundOriginalSizeDelta;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	protected override void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void CloseNotification()
	{
	}

	private void ResetNotificationUI()
	{
	}

	private void ChangeState(subscriberJoinedStateType newState)
	{
	}

	private void HandleState()
	{
	}

	private void HandleWaitBeforeStart(float currentStateTime)
	{
	}

	private void HandleStartState(float currentStateTime)
	{
	}

	private void HandleHighlightState(float currentStateTime)
	{
	}

	private void HandleClosingDownState(float currentStateTime)
	{
	}

	private void UpdateBoostTextEffect(float stateProgress)
	{
	}

	private void FadeOut(float stateProgress)
	{
	}

	private void CloseNotificationAnimation(float stateProgress)
	{
	}
}
