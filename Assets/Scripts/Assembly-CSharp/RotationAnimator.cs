using UnityEngine;

public class RotationAnimator : MonoBehaviour
{
	[SerializeField]
	private RectTransform rotateTarget;

	[SerializeField]
	[Tooltip("Rotation animation curve, value 1 = full rotation")]
	private AnimationCurve rotateCurve;

	[SerializeField]
	private float rotateSpeed;

	private void Update()
	{
	}
}
