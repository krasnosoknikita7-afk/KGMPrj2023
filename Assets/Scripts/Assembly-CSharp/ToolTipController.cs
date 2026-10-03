using UnityEngine;
using UnityEngine.EventSystems;

public class ToolTipController : MonoBehaviour, IHandleToolTip, IEventSystemHandler
{
	private bool updatedThisFrame;

	[SerializeField]
	private ToolTipUI toolTipUi;

	private void Awake()
	{
	}

	public void SendToolTip(Vector2 position, string toolTip)
	{
	}

	private void LateUpdate()
	{
	}
}
