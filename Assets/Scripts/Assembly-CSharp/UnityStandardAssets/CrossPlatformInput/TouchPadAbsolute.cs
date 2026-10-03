using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UnityStandardAssets.CrossPlatformInput
{
	[RequireComponent(typeof(Image))]
	public class TouchPadAbsolute : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Flags]
		public enum State
		{
			None = 0,
			Horizontal = 1,
			Vertical = 2
		}

		private CrossPlatformInputManager.VirtualAxis horizontalVirtualAxis;

		private CrossPlatformInputManager.VirtualAxis verticalVirtualAxis;

		private Vector2 previousInputPosition;

		private bool dragging;

		private State state;

		public string horizontalAxisName;

		public string verticalAxisName;

		public string onTouchButtonName;

		private int fingerId;

		public State AxisState
		{
			set
			{
			}
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void CreateVirtualAxes()
		{
		}

		private void RegisterAxes()
		{
		}

		private void SetOnPointButton(bool isDown)
		{
		}

		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		public void OnPointerUp(PointerEventData data)
		{
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		private void UpdateAxis()
		{
		}

		private void Reset()
		{
		}

		private bool TryGetTouch(out Touch touch, int fingerId)
		{
			touch = default;
			return false;
		}
	}
}
