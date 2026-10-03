using UnityEngine;

public class GamePassesHighlightArrow : MonoBehaviour
{
	[SerializeField]
	private RectTransform transformToMove;

	[SerializeField]
	private AnimationCurve moveCurve;

	[SerializeField]
	private float moveAmount;

	[SerializeField]
	private float directionX;

	[SerializeField]
	private float directionY;

	private float moveStartTime;

	private Vector3 startPosition;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
