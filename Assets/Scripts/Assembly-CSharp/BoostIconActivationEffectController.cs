using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoostIconActivationEffectController : MonoBehaviour
{
	private enum EffectState
	{
		Inactive = 0,
		Showing = 1,
		Fading = 2
	}

	[Serializable]
	private struct BoosterIcons
	{
		public BoostType type;

		public GameObject icon;
	}

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private NotificationFade fader;

	[SerializeField]
	private List<BoosterIcons> boosterIcons;

	[SerializeField]
	private float showingDuration;

	[SerializeField]
	private float fadingDuration;

	[SerializeField]
	private float startNewEffectDelay;

	[SerializeField]
	private float fadingSlideAmount;

	private EffectState currentState;

	private float stateStartTime;

	private float originalYPosition;

	private bool haveStartedNewEffect;

	private BoostType boostType;

	private UnityAction startNewEffect;

	public void Initialize(BoostType type, UnityAction startNewEffect)
	{
	}

	public void Activate()
	{
	}

	private void Update()
	{
	}

	private void SetState(EffectState newState)
	{
	}
}
