using UnityEngine;
using UnityEngine.EventSystems;

public class HoverEnabler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private GameObject objectToEnable;

	[SerializeField]
	private GameObject objectToDisable;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void OnDisable()
	{
	}
}
