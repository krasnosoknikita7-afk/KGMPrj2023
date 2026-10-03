using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.AdIntegration;
using UnityEngine;
using UnityEngine.EventSystems;

public class BoostMenuController : MonoBehaviour, IBoostAdController, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CFixContentPivot_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoostMenuController _003C_003E4__this;

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
		public _003CFixContentPivot_003Ed__9(int _003C_003E1__state)
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
	private BoostMenuItem boostPrefab;

	[SerializeField]
	private RectTransform boostItemsScrollRect;

	[SerializeField]
	private RectTransform boostItemsContent;

	private BoostType adRewardType;

	private Action<bool> boostUnlockedCallback;

	public void Initialize()
	{
	}

	public void TryShowAd(BoostType type, Action<bool> OnUnlockedCallback)
	{
	}

	private void RewardedAdCallback(RewardedAdResult obj)
	{
	}

	private void OnAdFinished(bool adWasSuccessful)
	{
	}

	[IteratorStateMachine(typeof(_003CFixContentPivot_003Ed__9))]
	private IEnumerator FixContentPivot()
	{
		return null;
	}

	private List<Boost> GetSortedBoosts(Dictionary<BoostType, Boost>.ValueCollection boosts, BoostController boostController)
	{
		return null;
	}
}
