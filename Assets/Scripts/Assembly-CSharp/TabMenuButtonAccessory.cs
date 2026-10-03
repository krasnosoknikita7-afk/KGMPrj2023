using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TabMenuButtonAccessory : TabMenuButtonBase, IHighlightedElement
{
	[Serializable]
	private struct AccessoryTabDef
	{
		public AccessoryCategoryClient tabID;

		public Graphic streamedImagePrefab;
	}

	[CompilerGenerated]
	private sealed class _003CLerpToSize_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TabMenuButtonAccessory _003C_003E4__this;

		public float size;

		private float _003Cheight_003E5__2;

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
		public _003CLerpToSize_003Ed__15(int _003C_003E1__state)
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
	private Button button;

	[SerializeField]
	private LayoutElement layoutElement;

	[SerializeField]
	private List<AccessoryTabDef> tabDefs;

	[SerializeField]
	private float selectedTabHeight;

	[SerializeField]
	private float lerpTime;

	[SerializeField]
	private GameObject redDot;

	[SerializeField]
	private Text redDotCount;

	private float startTime;

	private Graphic icon;

	private float defaultHeight;

	private AccessoryCategoryClient category;

	public override void Initialize(int tabId, string categoryName)
	{
	}

	public void UpdateHighlightState()
	{
	}

	public override void SetAsSelected()
	{
	}

	public override void SetAsDeselected()
	{
	}

	[IteratorStateMachine(typeof(_003CLerpToSize_003Ed__15))]
	private IEnumerator LerpToSize(float size)
	{
		return null;
	}
}
