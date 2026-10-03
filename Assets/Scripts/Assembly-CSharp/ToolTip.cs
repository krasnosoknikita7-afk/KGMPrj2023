using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform))]
public class ToolTip : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private bool hasEntered;

	[SerializeField]
	private RectTransform rectTransform;

	[SerializeField]
	private string toolTipText;

	private float pointerEnterTime;

	private Vector2 mousePosOnToolTip;

	private bool mousePosOnToolTipSet;

	private const float timeBeforeToolTip = 0.1f;

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	public void SetText(string textToBeChanged)
	{
	}

	private void LanguageLoadedCallback()
	{
	}

	private void Update()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
