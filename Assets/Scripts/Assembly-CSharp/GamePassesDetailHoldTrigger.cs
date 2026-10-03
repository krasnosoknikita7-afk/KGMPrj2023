using MV.Common;
using UnityEngine;
using UnityEngine.EventSystems;

public class GamePassesDetailHoldTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private GamePassesShopDetails gamePassesShopDetails;

	[SerializeField]
	private GamePassTier tierToShowDetailsFor;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
