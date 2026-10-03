using UnityEngine;
using UnityEngine.EventSystems;

public class GameEarningDetailHoldTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private GameEarningsMenu earningsMenu;

	[SerializeField]
	private int earningToShowDetailsFor;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
