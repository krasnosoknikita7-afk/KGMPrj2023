using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TouristPromotion : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFadeOutAndPopPromotion_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TouristPromotion _003C_003E4__this;

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
		public _003CFadeOutAndPopPromotion_003Ed__13(int _003C_003E1__state)
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
	private RectTransform promotionImageParent;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Text promotionHeader;

	[SerializeField]
	private TouristPromotionLooksData looksData;

	[SerializeField]
	private GameObject adIcon;

	protected bool promotionShowsAd;

	protected bool embedded;

	public static void TPLog(string msg)
	{
	}

	protected virtual void Start()
	{
	}

	public void Initialize(bool withAd)
	{
	}

	public void OnRegisterClicked()
	{
	}

	public void OnLoginClicked()
	{
	}

	public virtual void OnContinueClicked()
	{
	}

	[IteratorStateMachine(typeof(_003CFadeOutAndPopPromotion_003Ed__13))]
	private IEnumerator FadeOutAndPopPromotion()
	{
		return null;
	}
}
