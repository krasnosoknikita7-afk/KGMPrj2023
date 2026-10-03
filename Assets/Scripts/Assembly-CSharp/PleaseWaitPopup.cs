using UnityEngine;
using UnityEngine.UI;

public class PleaseWaitPopup : MonoBehaviour
{
	[SerializeField]
	private RectTransform rectTransform;

	[SerializeField]
	private float spinSpeed;

	[SerializeField]
	private CanvasGroup popUpcanvasGroup;

	[SerializeField]
	private AnimationCurve alphaCurveOverTime;

	[SerializeField]
	private float fullyRevealedTime;

	[SerializeField]
	private Image fullScreenBackGround;

	[SerializeField]
	private float fullScreenBackGroundMaxAlpha;

	private readonly Vector3 direction;

	private float timeSinceStart;

	private void Update()
	{
	}
}
