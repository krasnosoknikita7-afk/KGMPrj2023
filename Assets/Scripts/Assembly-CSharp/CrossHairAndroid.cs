using UnityEngine;
using UnityEngine.UI;

public class CrossHairAndroid : MonoBehaviour, IGUICrossHair
{
	[SerializeField]
	protected Image crossHair;

	[SerializeField]
	private Text ammoCount;

	[SerializeField]
	private Image chargeFill;

	[SerializeField]
	private GameObject ammoRoot;

	[SerializeField]
	private Image crossHairHitEnemyIndicator;

	[SerializeField]
	private AnimationCurve fadeCurve;

	[SerializeField]
	private float toggleInterval;

	private float timeSinceLastToggle;

	private bool isFillOn;

	[SerializeField]
	protected Color alphaBase;

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

	private void Update()
	{
	}

	public void HolsterStateChanged(bool isHolstered)
	{
	}

	public virtual void UpdateCrossHair(PickupItem pickupItem)
	{
	}

	protected void SetAlphaBaseToColor(Color color)
	{
	}
}
