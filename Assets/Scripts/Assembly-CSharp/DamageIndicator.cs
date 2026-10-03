using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class DamageIndicator : MonoBehaviour
{
	private class IndicatorArrow
	{
		private static IndicatorArrow _nextArrow;

		private static float indicationRadius;

		private IndicatorArrow nextArrow;

		private DamageArrow arrow;

		private Transform damageOrigin;

		private float timer;

		private bool idle;

		public static IndicatorArrow NextArrow => null;

		public IndicatorArrow(int numberOfArrows, DamageArrow arrowBase, float indicationRadius)
		{
		}

		private IndicatorArrow(int numberOfArrows, DamageArrow arrowBase, IndicatorArrow firstArrow)
		{
		}

		public void Show(Transform origin, float time, float indicationRadius)
		{
		}

		public void Update()
		{
		}

		public void Reset()
		{
		}

		public void SetSprite(Sprite sprite)
		{
		}

		private void UpdateArrowPosition()
		{
		}

		private void InternalUpdate()
		{
		}

		private void InternalReset()
		{
		}
	}

	[SerializeField]
	[Tooltip("Distance from center, for indicator arrow to appear.")]
	[Header("Configuration")]
	private float indicationRadius;

	[Tooltip("Transparency [0..1] by time [0..1] remaining")]
	[SerializeField]
	private AnimationCurve fade;

	[SerializeField]
	private float durationPerPointOfDamage;

	[SerializeField]
	private int maxNumberOfArrows;

	[Header("Dependencies")]
	[SerializeField]
	private Image damageOverlay;

	[SerializeField]
	private StreamedSpriteToCallback arrowSpriteStream;

	[SerializeField]
	private DamageArrow directionArrowBase;

	private IndicatorArrow directionArrow;

	private float damageOverlayTimer;

	private float timeNormalizationFactor;

	private float initialAlpha;

	private void Awake()
	{
	}

	private void SetArrowSprites(Sprite sprite)
	{
	}

	public void ResetIndicators()
	{
	}

	public void ShowDamage(float damageAmount, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	private void Update()
	{
	}

	private void SetTransparency(Image i, float alpha)
	{
	}
}
