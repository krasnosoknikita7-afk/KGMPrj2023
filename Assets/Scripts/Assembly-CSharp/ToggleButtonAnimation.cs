using UnityEngine;

public class ToggleButtonAnimation : MonoBehaviour
{
	[SerializeField]
	private RectTransform toggleOffMaskTransform;

	[SerializeField]
	private RectTransform toggleOffContentTransform;

	[SerializeField]
	private RectTransform toggleButtonTransform;

	[SerializeField]
	private bool isToggleOn;

	[SerializeField]
	private float toggleInterpolationDuration;

	[SerializeField]
	private float toggleButtonMoveAmount;

	private float toggleOffOriginalPositionX;

	private float toggleButtonOriginalPositionX;

	private float interpolateToggleMaskStartPositionX;

	private float interpolateToggleMaskNewPositionX;

	private float interpolateToggleContentStartPositionX;

	private float interpolateToggleContentNewPositionX;

	private float interpolateToggleButtonStartPositionX;

	private float interpolateToggleButtonNewPositionX;

	private float interpolationStartTime;

	private bool isInitialized;

	public bool IsToggleOn => false;

	private void Start()
	{
	}

	public void Initialize()
	{
	}

	public void ToggleOn()
	{
	}

	public void ToggleOff()
	{
	}

	public void Toggle()
	{
	}

	public void SetToggleOnWithoutInterpolation()
	{
	}

	public void SetToggleOffWithoutInterpolation()
	{
	}

	private void HandleToggle()
	{
	}

	private void Update()
	{
	}
}
