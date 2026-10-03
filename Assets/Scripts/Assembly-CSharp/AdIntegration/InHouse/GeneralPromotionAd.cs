using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace AdIntegration.InHouse
{
	public class GeneralPromotionAd : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFadeOutAndPop_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GeneralPromotionAd _003C_003E4__this;

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
			public _003CFadeOutAndPop_003Ed__37(int _003C_003E1__state)
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
		private GameObject redirectButton;

		[SerializeField]
		private Text redirectButtonURLText;

		[SerializeField]
		private GameObject goToKogamaPopupPrefab;

		[SerializeField]
		private GameObject actionButton;

		[SerializeField]
		private Text actionText;

		[SerializeField]
		private Button continueButton;

		[SerializeField]
		private Text continueText;

		[SerializeField]
		private Image continueAdIcon;

		[SerializeField]
		private EmbeddedPlayerConfig embeddedPlayerConfig;

		[SerializeField]
		private Text whySeeingThisText;

		private GeneralPromotionType generalPromotionType;

		private float startTime;

		private float secondsToWait;

		private bool finishedWaiting;

		private bool promotionShowsAd;

		private string startContinueText;

		private bool popped;

		private PromotionActionType promotionActionType;

		private EmbeddedSiteConfigData embeddedSiteConfigData;

		private bool redirectAllowed;

		private string StartContinueText => null;

		private void Start()
		{
		}

		private void Initialize(PromotionLooksData promotionLooksData, GeneralPromotionType type, bool showWhyText)
		{
		}

		public void InitializeWithTimer(GeneralPromotionInitTimer initTimer)
		{
		}

		public void InitializeWithAd(GeneralPromotionInitWithAd initWithAd)
		{
		}

		private static void OnWinningConditionFulfilled(IWinningCondition winningCondition)
		{
		}

		private void OnDestroy()
		{
		}

		public void KogamaRedirect()
		{
		}

		private void ShowGoToKogamaPopup()
		{
		}

		public void ActionButtonCallback()
		{
		}

		private void PerformAction(string statKey, UnityAction<bool, bool> action)
		{
		}

		public void OnContinueClicked()
		{
		}

		public void Pop()
		{
		}

		[IteratorStateMachine(typeof(_003CFadeOutAndPop_003Ed__37))]
		private IEnumerator FadeOutAndPop()
		{
			return null;
		}

		private void Update()
		{
		}

		private void ActivateContinueButton()
		{
		}
	}
}
