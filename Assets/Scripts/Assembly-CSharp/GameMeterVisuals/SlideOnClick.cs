using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameMeterVisuals
{
	public class SlideOnClick : GameMeterVisualEffect, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[CompilerGenerated]
		private sealed class _003CSlideTowardsPosition_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SlideOnClick _003C_003E4__this;

			private float _003Ci_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSlideTowardsPosition_003Ed__14(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private Vector3 targetPos;

		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private float lerpSpeed;

		[SerializeField]
		private float waitBeforeMoveBack;

		[SerializeField]
		private bool ignoreY;

		private bool readyForSlide;

		private bool holding;

		public Vector3 StartPos { get; private set; }

		private void Start()
		{
		}

		public void SetNewStartPosition(Vector3 newPos)
		{
		}

		public override void ExecuteEffect()
		{
		}

		[IteratorStateMachine(typeof(_003CSlideTowardsPosition_003Ed__14))]
		private IEnumerator SlideTowardsPosition()
		{
			return null;
		}

		private void LerpToPos(Vector2 from, Vector2 to, float i)
		{
		}

		private void OnDisable()
		{
		}

		private void SetToPosition(Vector2 pos)
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
