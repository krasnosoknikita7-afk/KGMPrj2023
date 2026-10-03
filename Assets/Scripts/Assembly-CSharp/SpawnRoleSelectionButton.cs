using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnRoleSelectionButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler
{
	[SerializeField]
	private SpawnRoleMenu spawnRoleMenu;

	private bool isMouseOver;

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
