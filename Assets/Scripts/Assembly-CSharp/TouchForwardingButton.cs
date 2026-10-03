using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class TouchForwardingButton : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler
{
	[SerializeField]
	private TouchPadAbsolute touchPadAbsolute;

	[SerializeField]
	private bool horizontalEnabled;

	[SerializeField]
	private bool verticalEnabled;

	private bool initialized;

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void Start()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
