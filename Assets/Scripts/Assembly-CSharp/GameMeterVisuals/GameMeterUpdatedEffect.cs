using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GameMeterVisuals
{
	public class GameMeterUpdatedEffect : GameMeterVisualEffect
	{
		[CompilerGenerated]
		private sealed class _003CAnimateScale_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameMeterUpdatedEffect _003C_003E4__this;

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
			public _003CAnimateScale_003Ed__6(int _003C_003E1__state)
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
		private float scaleStrength;

		[SerializeField]
		private float scaleTime;

		[SerializeField]
		private RectTransform scaleTarget;

		private Vector3 startSize;

		private void OnEnable()
		{
		}

		public override void ExecuteEffect()
		{
		}

		[IteratorStateMachine(typeof(_003CAnimateScale_003Ed__6))]
		private IEnumerator AnimateScale()
		{
			return null;
		}

		private void OnDisable()
		{
		}
	}
}
