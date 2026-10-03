using System;
using UnityEngine;
using UnityEngine.UI;

public class ModifierIndicator : MonoBehaviour
{
	[Serializable]
	private struct AnimatedImage
	{
		public Image image;

		public ImageAnimator animator;

		public StreamingAsset streamComponent;

		public CanvasGroup alphaHandler;
	}

	private class OverlayWrapper
	{
		private AnimationCurve fadeOutCurve;

		private AnimatedImage image;

		private float fadeOutTimer;

		private Image Image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private ImageAnimator Animator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private float Alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public OverlayWrapper(AnimatedImage overlayImage, AnimationCurve fadeOutCurve)
		{
		}

		public void Update(bool active)
		{
		}

		public void Reset()
		{
		}
	}

	private enum EOverlay : byte
	{
		Poison = 0,
		Fire = 1,
		Ice = 2,
		Size = 3
	}

	[SerializeField]
	private AnimatedImage poisonOverlay;

	[SerializeField]
	private AnimatedImage fireOverlay;

	[SerializeField]
	private AnimatedImage iceOverlay;

	[SerializeField]
	private AnimationCurve fadeOutCurve;

	private OverlayWrapper[] modifierIndicators;

	private MVInteractableBase localInteractable;

	private void OnValidate()
	{
	}

	public void Awake()
	{
	}

	public void Initialize(MVAvatarLocal localAvatar)
	{
	}

	private void Update()
	{
	}

	public void ResetIndicators()
	{
	}
}
