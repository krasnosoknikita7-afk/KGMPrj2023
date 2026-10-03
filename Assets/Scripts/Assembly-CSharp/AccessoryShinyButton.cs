using UnityEngine;
using UnityEngine.UI;

public class AccessoryShinyButton : MonoBehaviour
{
	[SerializeField]
	private RectTransform buttonRect;

	[SerializeField]
	private Transform buttonShine;

	[SerializeField]
	private AnimationCurve buttonShinePositionCurve;

	[SerializeField]
	private Image topFlare;

	[SerializeField]
	private AnimationCurve topFlarePositionCurve;

	[SerializeField]
	private Image bottomFlare;

	[SerializeField]
	private AnimationCurve bottomFlarePositionCurve;

	[SerializeField]
	private AnimationCurve flareAlphaCurve;

	[SerializeField]
	private float animationDuration;

	private float currentProgress;

	private RectTransform shine;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
