using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonAnimationController : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
	private enum ButtonType : byte
	{
		Square = 0,
		Small = 1
	}

	private const float pressedSquareMoveAmount = -15f;

	private const float hoverSquareMoveAmount = 0f;

	private const float disableSquareMoveAmount = -10f;

	private const float pressedSmallMoveAmount = -3f;

	private const float hoverSmallMoveAmount = 0f;

	private const float disableSmallMoveAmount = -1f;

	private float pressedMoveAmount;

	private float hoverMoveAmount;

	private float disableMoveAmount;

	[SerializeField]
	private Transform transformToMove;

	[SerializeField]
	private Button button;

	[SerializeField]
	private ButtonType buttonType;

	private float originalValue;

	private short buttonPressedState;

	private short buttonHighlightedState;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	private void OnDisable()
	{
	}

	private void HandleButtonDisabled()
	{
	}

	private void SetMoveAmount()
	{
	}
}
