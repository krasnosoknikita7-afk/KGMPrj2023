using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class FirstTimeActivatablePointerObjectives : FirstTimeActivatableElementBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public FirstTimeActivatablePointerObjectives _003C_003E4__this;

		public RectTransform target;

		internal void _003CCreateBubble_003Eb__0(TextBubbleController x, BaseEventData y)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCreateBubble_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FirstTimeActivatablePointerObjectives _003C_003E4__this;

		private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

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
		public _003CCreateBubble_003Ed__15(int _003C_003E1__state)
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
	private List<RectTransform> winningConditionTransforms;

	[SerializeField]
	private Vector2 pointerBodyDirectionOffset;

	[SerializeField]
	private List<RectTransform> bubbleContent;

	[SerializeField]
	private float bubbleLifetimeWhenVisible;

	[SerializeField]
	private float visibleDuration;

	private bool visible;

	private float currentTime;

	private const string mouseX = "Mouse X";

	private const string mouseY = "Mouse Y";

	private bool isUpdating;

	private int bubbleId;

	public override bool CanShow => false;

	private void Update()
	{
	}

	public override void OnShow()
	{
	}

	[IteratorStateMachine(typeof(_003CCreateBubble_003Ed__15))]
	private IEnumerator CreateBubble()
	{
		return null;
	}

	private void Clear()
	{
	}

	private void OnShown()
	{
	}

	private void Destroy()
	{
	}
}
