using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryTurnPage : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
{
	[SerializeField]
	private bool pageForward;

	[SerializeField]
	private Button button;

	private void Start()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	private void TurnPage(IPagedTurned pagedTurned)
	{
	}
}
