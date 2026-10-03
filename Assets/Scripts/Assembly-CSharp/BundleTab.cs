using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class BundleTab : TabMenuButtonBase
{
	[CompilerGenerated]
	private sealed class _003CLerpToSize_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BundleTab _003C_003E4__this;

		public float size;

		private Vector2 _003Cpos_003E5__2;

		private float _003CxPos_003E5__3;

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
		public _003CLerpToSize_003Ed__20(int _003C_003E1__state)
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
	private RectTransform rectTransform;

	[SerializeField]
	private float offsetX;

	[SerializeField]
	private float lerpTime;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private RawImage levelBadge;

	[SerializeField]
	private Text timeLimitText;

	[SerializeField]
	private GameObject redDot;

	[SerializeField]
	private Text redDotCount;

	private Texture2D badgeTextureAsset;

	private float startPos;

	private float startTime;

	private int highlightId;

	public override void Initialize(int tabId, string categoryName)
	{
	}

	private void SetLevelBadge()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnBadgeLoaded(UnityWebRequest www)
	{
	}

	public override void SetAsSelected()
	{
	}

	public override void SetAsDeselected()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CLerpToSize_003Ed__20))]
	private IEnumerator LerpToSize(float size)
	{
		return null;
	}
}
