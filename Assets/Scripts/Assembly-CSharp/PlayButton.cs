using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayButton : PlayButtonBase, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler
{
	[SerializeField]
	private TimedPlayReward timedPlayReward;

	[SerializeField]
	private Button button;

	[SerializeField]
	private bool shouldConfirmPlay;

	[SerializeField]
	private ContinueButtonLockCursor continueButtonPrefab;

	[SerializeField]
	private Image adIcon;

	[SerializeField]
	private Image playIcon;

	[SerializeField]
	private EmbeddedPlayerConfig embeddedPlayerConfig;

	private bool isMouseOver;

	public Action OnPlayButtonPressed;

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void Play()
	{
	}

	private void OnPromotionShown(bool promotionShown, bool withAd)
	{
	}

	private void OnContinuePressed()
	{
	}

	private void HandlePlayPress()
	{
	}

	private void ConfirmPlay()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	protected virtual bool HandlePlayAvailable()
	{
		return false;
	}

	protected override void OnCountDownEnd()
	{
	}
}
