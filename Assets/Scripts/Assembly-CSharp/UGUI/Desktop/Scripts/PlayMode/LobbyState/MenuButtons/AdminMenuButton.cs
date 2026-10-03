using UnityEngine;
using UnityEngine.EventSystems;

namespace UGUI.Desktop.Scripts.PlayMode.LobbyState.MenuButtons
{
	public abstract class AdminMenuButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler
	{
		[SerializeField]
		protected bool shouldPop;

		private bool isMouseOver;

		protected abstract void DoAction();

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
}
