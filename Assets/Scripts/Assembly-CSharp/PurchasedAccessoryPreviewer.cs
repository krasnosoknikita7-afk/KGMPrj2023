using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PurchasedAccessoryPreviewer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisplayAndFadeImages_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PurchasedAccessoryPreviewer _003C_003E4__this;

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
		public _003CDisplayAndFadeImages_003Ed__17(int _003C_003E1__state)
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
	private Image image;

	[SerializeField]
	private StreamedSpriteToImageManual imageLoader;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image backgroundGlow;

	[SerializeField]
	private float imageDisplayTime;

	[SerializeField]
	private float imageBounceEffectTime;

	[SerializeField]
	private AnimationCurve bounceEffect;

	[SerializeField]
	private AnimationCurve fadeEffect;

	private float currentTime;

	private AccessoryDataClient[] previewData;

	private int currentStreamingAssetIndex;

	private Color targetColorBackground;

	private Color targetColorGlow;

	private int targetHeight;

	public void Initialize(AccessoryDataClient[] previewAccessories)
	{
	}

	private void OnShow()
	{
	}

	private string GetImageUrl(AccessoryDataClient accessoryDataClient)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDisplayAndFadeImages_003Ed__17))]
	private IEnumerator DisplayAndFadeImages()
	{
		return null;
	}

	private void EvaluateImageAtTime(float bounceTime, float colorTime)
	{
	}
}
