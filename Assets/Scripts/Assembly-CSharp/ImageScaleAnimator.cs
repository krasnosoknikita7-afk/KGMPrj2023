using UnityEngine;

public class ImageScaleAnimator : MonoBehaviour
{
	[SerializeField]
	private RectTransform scaleTarget;

	[Tooltip("Scale negative for downscaling")]
	[SerializeField]
	private AnimationCurve scaleCurve;

	[SerializeField]
	private float scaleSpeed;

	private Vector2 startSize;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
