using UnityEngine;
using UnityEngine.UI;

public class GamePointGainEffectCountController : MonoBehaviour
{
	private enum SlideState
	{
		Active = 0,
		InActive = 1,
		Showing = 2,
		Hiding = 3
	}

	[SerializeField]
	private Text gamePointAmount;

	[SerializeField]
	private Transform transformToSlide;

	[SerializeField]
	private float slideMoveAmount;

	[SerializeField]
	private float slideDuration;

	[SerializeField]
	private float slideOutDelay;

	[SerializeField]
	private AnimationCurve textEffectCurve;

	private int startValue;

	private int endValue;

	private int gainEffectAmountReached;

	private int gainEffectTotalAmount;

	private float textEffectStartTime;

	private int currentGamePointAmountDisplayed;

	private float originalXPosition;

	private float slideStartTime;

	private float startSlideOutTime;

	private SlideState currentSlideState;

	public void SetupAmountCatchingUp(int endValueParam, int gainEffectTotalAmountParam)
	{
	}

	public void OnGamePointGainEffectStarted()
	{
	}

	public void OnGamePointGainEffectReached()
	{
	}

	public void UpdateGamePointAmountTextToValue(int updateToValue)
	{
	}

	public void HideCount()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateGamePointAmountTextEffect()
	{
	}

	private void HandleSlideState()
	{
	}

	private void HandleSlideIn()
	{
	}

	private void HandleSlideOut()
	{
	}
}
