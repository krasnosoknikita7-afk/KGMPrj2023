using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputFieldFocusHidePlaceholderText : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	[SerializeField]
	private Text placeholderText;

	public void OnSelect(BaseEventData data)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}
}
