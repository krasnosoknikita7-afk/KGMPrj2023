using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBoostNotification : Notification
{
	private enum XPBoostStateType : byte
	{
		NotInitializedState = 0,
		WaitBeforeStartState = 1,
		StartState = 2,
		HighlightState = 3,
		ClosingDownState = 4,
		EndState = 5
	}

	[SerializeField]
	private Text boostAmountText;

	[SerializeField]
	private Text UserNameText1;

	[SerializeField]
	private Text UserNameText2;

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

	[SerializeField]
	private AnimationCurve slideUserNameOutCurve;

	[SerializeField]
	private AnimationCurve slideUserNameInCurve;

	private const float waitBeforeStartDuration = 1f;

	private const float startDuration = 1.5f;

	private const float memberHighlightDuration = 2f;

	private const float closeDuration = 0.5f;

	private const float boostEffectOnStartDelay = 0.208334f;

	private float stateStartTime;

	private List<MVPlayer> memberList;

	private int currentMemberBeingHighlighted;

	private XPBoostStateType currentState;

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

	private void CloseNotification()
	{
	}

	private void UpdateBoostAmount()
	{
	}

	private void ChangeState(XPBoostStateType newState)
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

	private void StartNextState()
	{
	}

	private void StartNewMemberHighlight()
	{
	}

	private bool IsMemberHighlightingDone()
	{
		return false;
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

	private void CloseNotification(float stateProgress)
	{
	}

	private void SwapMemberName(float stateProgress)
	{
	}

	private void SlideOutName(float stateProgress)
	{
	}

	private void SlideInName(float stateProgress)
	{
	}
}
