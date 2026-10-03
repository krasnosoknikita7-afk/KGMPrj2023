using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RegisteredPromotionPopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFadeOutAndPopPromotion_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RegisteredPromotionPopup _003C_003E4__this;

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
		public _003CFadeOutAndPopPromotion_003Ed__17(int _003C_003E1__state)
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
	private Text promotionHeader;

	[SerializeField]
	private RectTransform promotionImageParent;

	[SerializeField]
	private Text redirectButtonURLText;

	[SerializeField]
	private TouristPromotionLooksData looksData;

	[SerializeField]
	private GameObject goToKogamaPopupPrefab;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Button continueButton;

	[SerializeField]
	private Image adIcon;

	private bool waitingForAd;

	private float startTime;

	private float timeoutDelay;

	private bool withAd;

	public void Initialize(bool isEmbeddedPromotion, bool withAd)
	{
	}

	protected void OnDestroy()
	{
	}

	public void KogamaRedirect()
	{
	}

	public void OnContinueClicked()
	{
	}

	public void OnViewAdClicked()
	{
	}

	[IteratorStateMachine(typeof(_003CFadeOutAndPopPromotion_003Ed__17))]
	private IEnumerator FadeOutAndPopPromotion()
	{
		return null;
	}

	private void OnWinningConditionFulfilled(IWinningCondition winningCondition)
	{
	}

	private void ShowGoToKogamaPopup()
	{
	}

	private void Update()
	{
	}
}
