using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class ContextMenuButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[SerializeField]
	private Button button;

	[SerializeField]
	private Text text;

	public void Initialize(string buttonText, UnityAction onClickCallback)
	{
	}

	public void Initialize(string buttonText)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
