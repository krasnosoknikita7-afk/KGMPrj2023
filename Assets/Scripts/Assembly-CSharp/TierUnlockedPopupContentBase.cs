using MV.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TierUnlockedPopupContentBase : MonoBehaviour
{
	protected enum PopupState
	{
		notStarted = 0,
		displaying = 1,
		done = 2
	}

	[SerializeField]
	protected Color backgroundColor;

	[SerializeField]
	protected float displayTime;

	[SerializeField]
	protected Text titleText;

	[SerializeField]
	protected NotificationFade titleTextFader;

	[SerializeField]
	protected RectTransform mainContent;

	[SerializeField]
	protected CanvasGroup mainContentCanvasGroup;

	private const float titleSlideAmount = 300f;

	private const float slideDuration = 0.2f;

	private float titleOriginalYPosition;

	private float slideInStartTime;

	private float slideOutStartTime;

	protected PopupState currentState;

	protected float stateStartTime;

	protected UnityAction onDisplayDoneCallback;

	public Color BackgroundColor => default;

	public float DisplayTime => 0f;

	public virtual void Initialize(GamePassTier unlockedGamePassTier, UnityAction onDisplayDoneCallback)
	{
	}

	public void UpdateScale(float newScale)
	{
	}

	public void UpdateAlpha(float newAlpha)
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void HandleDisplaying()
	{
	}

	protected void SetState(PopupState newState)
	{
	}

	protected void HandleSlideTitleText()
	{
	}
}
