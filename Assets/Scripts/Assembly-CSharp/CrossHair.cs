using UnityEngine;
using UnityEngine.UI;

public class CrossHair : MonoBehaviour, IGUICrossHair
{
	[SerializeField]
	private Image crossHair;

	[SerializeField]
	private Text ammoCount;

	[SerializeField]
	private Image chargeFill;

	[SerializeField]
	private float toggleInterval;

	[SerializeField]
	private Image crossHairHitEnemyIndicator;

	[SerializeField]
	private AnimationCurve fadeCurve;

	private float timeSinceLastToggle;

	private bool isFillOn;

	private float timer;

	private bool hitEffectActive;

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void ShowHasHitEffect()
	{
	}

	public void UpdateCrossHair(PickupItem pickupItem)
	{
	}

	private void Update()
	{
	}
}
